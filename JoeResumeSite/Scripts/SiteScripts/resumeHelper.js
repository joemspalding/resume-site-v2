var resumeHelper = (function ($) {
	"use strict";
	var module = {
		prop1: null,
		onready: function () {
			bindAnalyticsToResume();
		}
		
	};
	return module;
	var bindAnalyticsToResume = function () {
		ga('send', 'pageview');
	};
})(jQuery);