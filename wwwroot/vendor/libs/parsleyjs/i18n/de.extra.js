/*
 * ATTENTION: The "eval" devtool has been used (maybe by default in mode: "development").
 * This devtool is neither made for production nor for readable output files.
 * It uses "eval()" calls to create a separate source file in the browser devtools.
 * If you are trying to read the output file, select a different devtool (https://webpack.js.org/configuration/devtool/)
 * or disable the default devtool with "devtool: false".
 * If you are looking for production-ready output files, see mode: "production" (https://webpack.js.org/configuration/mode/).
 */
(function webpackUniversalModuleDefinition(root, factory) {
	if(typeof exports === 'object' && typeof module === 'object')
		module.exports = factory();
	else if(typeof define === 'function' && define.amd)
		define([], factory);
	else {
		var a = factory();
		for(var i in a) (typeof exports === 'object' ? exports : root)[i] = a[i];
	}
})(self, () => {
return /******/ (() => { // webpackBootstrap
/******/ 	var __webpack_modules__ = ({

/***/ "./src/libs/parsleyjs/i18n/de.extra.js":
/*!*********************************************!*\
  !*** ./src/libs/parsleyjs/i18n/de.extra.js ***!
  \*********************************************/
/***/ (() => {

eval("// Validation errors messages for Parsley\n// Load this after Parsley\n\nParsley.addMessages('de', {\n  dateiso: \"Die Eingabe muss ein gültiges Datum sein (YYYY-MM-DD).\",\n  minwords: \"Die Eingabe ist zu kurz. Sie muss aus %s oder mehr Wörtern bestehen.\",\n  maxwords: \"Die Eingabe ist zu lang. Sie muss aus %s oder weniger Wörtern bestehen.\",\n  words: \"Die Länge der Eingabe ist ungültig. Sie muss zwischen %s und %s Wörter enthalten.\",\n  gt: \"Die Eingabe muss größer sein.\",\n  gte: \"Die Eingabe muss größer oder gleich sein.\",\n  lt: \"Die Eingabe muss kleiner sein.\",\n  lte: \"Die Eingabe muss kleiner oder gleich sein.\"\n});\n\n//# sourceURL=webpack://Vuexy/./src/libs/parsleyjs/i18n/de.extra.js?");

/***/ })

/******/ 	});
/************************************************************************/
/******/ 	
/******/ 	// startup
/******/ 	// Load entry module and return exports
/******/ 	// This entry module can't be inlined because the eval devtool is used.
/******/ 	var __webpack_exports__ = {};
/******/ 	__webpack_modules__["./src/libs/parsleyjs/i18n/de.extra.js"]();
/******/ 	
/******/ 	return __webpack_exports__;
/******/ })()
;
});