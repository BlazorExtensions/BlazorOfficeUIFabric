import { Stylesheet } from "./Stylesheet";
import { getVendorSettings } from "./VendorSettings";
import { getRTL } from "./transforms/rtlifyRules";


namespace BlazorExtensions.MergeStyle {
  export var StyleSheet = new StyleSheet();
  export var GetVendorSettings = getVendorSettings;
  export var GetRTL = getRTL;
}
var t = [];
window["BlazorExtensions.MergeStyes"] = BlazorExtensions.MergeStyle;


