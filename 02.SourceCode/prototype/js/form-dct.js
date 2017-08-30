define(["zepto","happy","touch","frozen","dialog"],function(){
	//表单验证
	$("#dct-reg").isHappy({

		submitButton : $("#submit"),
        fields:{
            /*选中名字字段，设置校验规则,以下同理*/
            '#firstName':{
                //是否是必填的
                required:true,
                message:'请填写您的姓氏！'
            },
            '#lastName':{
                required:true,
                message:'请填写您的名字！',
            },
            '#gender':{
                required:true,
                message:'请选择性别！',
            },
            '#telNum':{
                required:true,
                message:'请填写您的手机号！',
                arg:'手机格式不正确！',
                test: happy.CNtel
            }                                     
        },
        happy:function(){
            //提交成功后的回调函数
		$("#dct-reg").submit();
            //alert('submit success');
        },
        unHappy:function(msg){
            //提交失败后的回调函数，
            console.log(msg);
            //var dialog = '<div class="ui-poptips ui-poptips-success"><div class="ui-poptips-cnt"><i></i>'+  +'</div></div>';
            var dia=$.dialog({
		        title:'',
		        content: msg,
		        button:["确认"]	
		    });
            dia.on("click",function(e){
		        dia.remove();
		    });
        },
        errorTemplate:function(error){
            //error是一个json对象，他结果如下

            /*{messge:'显示的错误信息',
               id:当前选择器的第一个字符+'_unhappy'}
             */
            return $('<span style="color:red;font-weight:bold" role="alert">' + error.message + '</span>');
        }
    })        
	//点击性别弹出选项
	$(".gender").click(function(){
		$("#chooseGender").addClass('show');	
		$("#chooseGender button").click(function(){
			$("#gender").val($(this).text());
			$("#chooseGender").removeClass('show');
		})
	})
})