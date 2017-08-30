require.config({
	paths: {
		"zepto" : "lib/zepto.min",
		"frozen" : "lib/frozen",
		"text" : "lib/require/text",
		"css" : "lib/require/css",
		"happy" : "lib/happy",
		"touch" : "lib/zeptojs/touch",
		"header1" : "../page/template/header-footer.html",
		"frozenCss" : "../css/frozen",
		"baseCss" : "../css/base",
		"dialog" : "lib/frozen/component/dialog"
	},
	shim: {
		"zepto" : {
			deps: [],
			exports: "$"
		},
		"frozen" : {
			deps: ["zepto"],
			exports: "F"
		},
		"dialog" : {
			deps: ["zepto","frozen"],
			exports: "dialog"
		},
		"happy" : {
			deps: ["zepto"],
			exports: "happy"
		}
	}
});





require(["zepto","text!header1","touch","css!frozenCss","css!baseCss"],function($,header,touch,frozencss,basecss){
	$(function(){
        $("body>section").eq(0).before(header);
        $('*').click(function(){
		    if($(this).data('href')){
		        location.href= $(this).data('href');
		    }
		});
		//头部导航回首页按钮
		$('.ui-header .ui-btn').click(function(){
		    location.href= 'index.html';
		});

    })
});



