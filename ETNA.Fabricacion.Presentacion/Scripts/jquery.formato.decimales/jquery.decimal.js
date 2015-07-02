/**
* Decimal Mask Plugin
* 
* @version 1.1.1
* 
* @licensed MIT License Copyright (c) 2010 St�fano Stypulkowski <http://www.icewares.com.br/license/MIT.txt>
* @licensed GPL LIcense Copyright (c) 2010 St�fano Stypulkowski <http://www.icewares.com.br/license/GPL.txt>
* 
* @requires jQuery 1.4.x
* @requires jQuery.caret.1.02.min.js
* 
* @author St�fano Stypulkowski
*/

(function ($) {
    $.fn.decimalMask = function (options) {
        var cfg = { separator: ",", decSize: 3, intSize: 7 }; var SEPARATORS = [",", "."];
        cfg = $.extend(cfg, options);
        sep = ".";
        var intL = cfg.intSize; var decL = cfg.decSize; var matchKey = function () {
            var is = false; for (var i = 1, l = arguments.length;
i < l; i++) { if (arguments[0] === arguments[i]) { is = true; break } } return is
        }; $(this).each(function () {
            $(this).attr("maxlength", (intL + decL + 1));
            var v = $(this).val().replace(".", sep); if (v.indexOf(sep) === 0) { v = "0" + value } $(this).val(v)
        }); var inputHandler = function (event) {
            var value = $(this).val();
            var newValue = ""; var haveSep = value.indexOf(sep) > -1 ? true : false; for (var i = 0, l = value.length; i < l; i++) {
                if (value.substring(i, i + 1).match("[0-9," + sep + "]")) {
                    if (value.substring(i, i + 1) === sep && newValue.indexOf(sep) === -1) {
                        newValue = newValue + value.substring(i, i + 1)
                    } if (value.substring(i, i + 1) !== sep) { newValue = newValue + value.substring(i, i + 1) }
                }
            } var parts = newValue.split(sep);
            if (parts[1] > decL) { parts[1] = parts[1].substring(0, decL) } if (parts[0] > intL) {
                parts[0] = parts[0].substring((parts[0].length - intL), parts[0].length)
            } $(this).val((parts[0] === undefined ? "" : parts[0]) + (haveSep ? sep : "") + (parts[1] === undefined ? "" : parts[1]))
        };
        var keyDownHandler = function (event) {
            var k = event.keyCode; if (event.shiftKey || event.ctrlKey || event.altKey) {
                return true
            } if (matchKey(k, 35, 36, 9, 110)) { return true } if (matchKey(k, 37, 38, 39, 40)) { return true } if (k === 46) {
                var value = $(this).val();
                if ($(this).caret().start === $(this).val().indexOf(sep) && $(this).caret().start == $(this).caret().end && value.length > 1 && value.indexOf(sep) > 0 && value.indexOf(sep) + 1 < value.length) {
                    return false
                } if (value.indexOf(sep) >= $(this).caret().start && value.indexOf(sep) < $(this).caret().end) {
                    $(this).val(value.substring(0, $(this).caret().start) + sep + value.substring($(this).caret().end, value.length));
                    if ($(this).val().length === 1) { $(this).val("") } return false
                } return true
            } if (k === 8) {
                var value = $(this).val();
                if ($(this).caret().start === value.indexOf(sep) + 1 && $(this).caret().start === $(this).caret().end && value.length > 1 && value.indexOf(sep) > 0 && value.indexOf(sep) + 1 < value.length) {
                    return false
                } if (value.indexOf(sep) >= $(this).caret().start && value.indexOf(sep) < $(this).caret().end) {
                    $(this).val(value.substring(0, $(this).caret().start) + sep + value.substring($(this).caret().end, value.length));
                    if ($(this).val().length === 1) { $(this).val("") } return false
                } return true
            } if (matchKey(k, 110, 188)) {
                if (sep === ".") {
                    return false
                } if (sep === "," && $(this).val().indexOf(",") !== -1) { return false } return true
            } if (matchKey(k, 190, 194, 110)) {
                if (sep === ",") {
                    return false
                } if (sep === "." && $(this).val().indexOf(".") !== -1) { return false } return true
            } if ((k >= 96 && k <= 105) || (k >= 48 && k <= 57)) {
                if ($(this).val().length > (intL + decL + 1)) {
                    return false
                } var val = $(this).val(); var parts = val.split(sep); if (matchKey(k, 48, 96) && $(this).caret().start === 0 && val.length > 0) {
                    return false
                } if ($(this).caret().start === $(this).caret().end) {
                    if ($(this).caret().start > val.indexOf(sep) && val.indexOf(sep) > -1 && parts[1].length >= decL) {
                        return false
                    } if (($(this).caret().start <= val.indexOf(sep) || val.indexOf(sep) == -1) && parts[0].length >= intL) {
                        return false
                    }
                } else {
                    if ($(this).caret().end - $(this).caret().start === val.length) { return true } if ($(this).caret().start <= val.indexOf(sep) && $(this).caret().end > val.indexOf(sep)) {
                        return false
                    }
                } return true
            } return false
        }; $(this).bind("input", inputHandler); $(this).bind("keydown", keyDownHandler)
    }
})(jQuery);
