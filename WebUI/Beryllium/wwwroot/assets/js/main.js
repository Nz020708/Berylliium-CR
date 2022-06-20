let drpdwn=document.querySelector(".drpdwn")
let drpdwnsecond=document.querySelector(".drpdwn-second")
let drpdwnmenu=document.querySelector(".drpdwn-menu")
let drpdwnmenusecond=document.querySelector(".drpdwn-menu-second")
let drpdwnli=document.querySelector(".drpdwn-menu li")
drpdwn.onmouseover=function DropDown() {
    drpdwnmenu.style.display="block";
    drpdwnmenu.style.marginTop=0;

}
drpdwnmenu.onmouseover=function() {
    drpdwnmenu.style.display="block";
    
}
drpdwnmenu.onmouseout=function() {
    drpdwnmenu.style.display="none";
    
}
drpdwn.onmouseout=function DropDown() {
    drpdwnmenu.style.display="none";
    drpdwnmenu.style.marginTop=0;

}
drpdwnsecond.onmouseover=function DropDownSecond() {
    drpdwnmenusecond.style.display="block";
}
drpdwnmenusecond.onmouseover=function() {
    drpdwnmenusecond.style.display="block";
    
}
drpdwnmenusecond.onmouseout=function() {
    drpdwnmenusecond.style.display="none";
    
}
drpdwnsecond.onmouseout=function DropDownSecond() {
    drpdwnmenusecond.style.display="none";
}
drpdwnli.onmouseover=function ChangeRowColorDisable() {
    drpdwnli.style.backgroundColor="black";

}
$(document).ready(function (){
    $('.slick').slick({
        dots:true,
        infinite: true,
        slidesToShow: 3,
        slidesToScroll: 3,
        adaptiveHeight: false,
        arrows: false,
       
      });
});
