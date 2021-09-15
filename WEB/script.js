function sendAjax(){
    var fromData = new FormData();
    fromData.append('username', 'jasondoe');
    fromData.append('id', 123456);
    //创建xhr对象
    var xhr = new XMLHttpRequest();
    xhr.timeout = 3000;
    //设置响应格式
    xhr.responseType = "text";
    xhr.open('POST', '/server', true);
    xhr.onload = function(e) {
        if(this.status == 200 || this.status == 304){
            alert(this.responseText);

        }
    };

    xhr.ontimeout = function(e){

    };

    xhr.onerror = function(e){
        console.error(e);
    };

    xhr.upload.onprogress = function(e) {

    };

    xhr.send(formData);
}