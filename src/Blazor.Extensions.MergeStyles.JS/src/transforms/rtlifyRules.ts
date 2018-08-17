
export function getRTL() {
  return typeof document !== 'undefined' &&
    !!document.documentElement &&
    document.documentElement.getAttribute('dir') === 'rtl';
}
