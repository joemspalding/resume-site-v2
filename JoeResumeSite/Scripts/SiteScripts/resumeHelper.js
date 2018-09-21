var resumeHelper = (function ($) {
	"use strict";
	var module = {
		onready: function () {
			addAnalytics();
		}
	};
	return module;
	function addAnalytics() {

		gtag('config', 'GA_TRACKING_ID');
	}
})(jQuery);