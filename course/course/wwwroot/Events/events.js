mainvid = document.getElementById("mainvid");


function pauseplay(){
    if (mainvid.paused) 
    mainvid.play(); 
  else 
    mainvid.pause();
}

function increase(){
    mainvid.width = 520;

}

function decrease(){
    mainvid.width = 320;
}

function reset(){
    mainvid.width=420;
}











var navbar = document.getElementById("navbar");

var sticky = navbar.offsetTop;

var T = window;

var background = document.getElementById("white");

var resetheheading = document.getElementById("reset");
var heading = document.getElementById("heading");

var increasefont = document.getElementById("font-inc");

var decreasefont = document.getElementById("font-dec");

var resetfont = document.getElementById("font-reset")

var welcome = document.getElementById("change");

function decrease(){
    welcome.setAttribute("class","decre");
    localStorage.fontsize = "small";
    
}

function increase(){
   welcome.setAttribute("class","increfont");
   localStorage.fontsize = "large";
    

}

function reset(){
    welcome.setAttribute("class","resetfont");
    localStorage.fontsize = "normal";
}

function resetcolor(){
    heading.setAttribute("class","h1");
    localStorage.color = "normal";
}

function backgroundcolor(){
    heading.setAttribute("class","newback");
    localStorage.color = "new";
}



 





function stickbar(){
    if (window.pageYOffset >= sticky){
        navbar.setAttribute("class","sticky")
    }else{
        navbar.removeAttribute("class","sticky");
    }
}




T.addEventListener("scroll",stickbar);

background.addEventListener("click",backgroundcolor);

resetheheading.addEventListener("click",resetcolor);



increasefont.addEventListener("click",increase);

decreasefont.addEventListener("click",decrease);

resetfont.addEventListener("click",reset);


if(localStorage.fontsize == "large"){
    welcome.setAttribute("class","increfont");
}

else if (localStorage.fontsize == "small"){
    welcome.setAttribute("class","decre");
}

if (localStorage.color == "new"){
    heading.setAttribute("class","newback");
}

else{
    heading.setAttribute("class","h1");
}