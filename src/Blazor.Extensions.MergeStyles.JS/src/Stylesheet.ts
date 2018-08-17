// tslint:disable-next-line:no-any
declare const process: { [key: string]: any };

const STYLESHEET_SETTING = '__stylesheet__';

// tslint:disable-next-line:no-any
const _fileScopedGlobal: { [key: string]: any } = {};

let _stylesheet: Stylesheet;


export enum InjectionMode {
  node,
  insertNode,
  appendChild
}


export class Stylesheet {
  private _lastStyleElement?: HTMLStyleElement;
  private _styleElement?: HTMLStyleElement;
  private _styleSheetRef!: DotNetReferenceType;
  private _stylesheet!: Stylesheet;

  /**
   * Gets the singleton instance.
   */
  public static getInstance(): Stylesheet {
    // tslint:disable-next-line:no-any
    const global: any =
      typeof window !== 'undefined' ? window : typeof process !== 'undefined' ? process : _fileScopedGlobal;
    _stylesheet = global[STYLESHEET_SETTING] as Stylesheet;

    if (!_stylesheet || (_stylesheet._lastStyleElement && _stylesheet._lastStyleElement.ownerDocument !== document)) {
      // tslint:disable-next-line:no-string-literal
      const fabricConfig = (global && global['FabricConfig']) || {};

      _stylesheet = global[STYLESHEET_SETTING] = new Stylesheet();
    }

    return _stylesheet;
  }


  public init = (styleSheet: DotNetReferenceType) => {
    this._styleSheetRef = styleSheet;
  }

  /**
 * Inserts a css rule into the stylesheet.
 * @param preserve - Preserves the rule beyond a reset boundary.
 */
  private InjectRule = (rule: string, injectionMode: InjectionMode, preserve?: boolean) => {

    var element = this._getStyleElement();

    switch (injectionMode) {
      case InjectionMode.insertNode:
        const { sheet } = element!;

        try {
          (sheet as CSSStyleSheet).insertRule(rule, (sheet as CSSStyleSheet).cssRules.length);
        } catch (e) {
          // The browser will throw exceptions on unsupported rules (such as a moz prefix in webkit.)
          // We need to swallow the exceptions for this scenario, otherwise we'd need to filter
          // which could be slower and bulkier.
        }
        break;

      case InjectionMode.appendChild:
        element!.appendChild(document.createTextNode(rule));
        break;
    }
  }


  private _createStyleElement(): HTMLStyleElement {
    const styleElement = document.createElement('style');

    styleElement.setAttribute('data-merge-styles', 'true');
    styleElement.type = 'text/css';

    if (this._lastStyleElement && this._lastStyleElement.nextElementSibling) {
      document.head.insertBefore(styleElement, this._lastStyleElement.nextElementSibling);
    } else {
      document.head.appendChild(styleElement);
    }
    this._lastStyleElement = styleElement;

    return styleElement;
  }

  private _getStyleElement(): HTMLStyleElement | undefined {
    if (!this._styleElement && typeof document !== 'undefined') {
      this._styleElement = this._createStyleElement();

      // Reset the style element on the next frame.
      window.requestAnimationFrame(() => {
        this._styleElement = undefined;
      });
    }
    return this._styleElement;
  }


}

