
//    var arr=["deepu","rahul","vasu"];
//    var text="";
//var i;
//for (i = 0; i < arr.length; i++) {
//    text += arr[i]+"<br>";
//}
//document.write(text);
function getalert() {
    var m1 = isNaN("2");
    var m2 = isNaN("Raman");
    var m3 = isNaN(2434);
    var d = eval("45*2");
    document.getElementById("ref").innerHTML += m1 + "<br>";
    document.getElementById("ref").innerHTML += m2 + "<br>";
    document.getElementById("ref").innerHTML += m3 + "<br>";
    document.getElementById("ref").innerHTML += d + "<br>";
    var m4 = parseInt("101", 2);
    var m5 = parseInt("11", 8);
    var m6 = parseInt("15", 10);
    var m7 = parseFloat("123ssdffg");
    var m8 = parseFloat("123.8990");
    document.getElementById("ref").innerHTML += m4 + "<br>";
    document.getElementById("ref").innerHTML += m5 + "<br>";
    document.getElementById("ref").innerHTML += m6 + "<br>";
    document.getElementById("ref").innerHTML += m7 + "<br>";
    document.getElementById("ref").innerHTML += m8 + "<br>";
}
//getalert();
function over(img, imgsrc) {
    img.src = imgsrc;
}
function out(img, imgsrc) {
    img.src = imgsrc;
}
