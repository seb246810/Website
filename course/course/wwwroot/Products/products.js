let products = document.getElementById("prod");
let originalwidth = products.width;
let increasewidth = originalwidth;



let bar = document.getElementById("bar");
let Owidth = bar.width;
let Iwidth = Owidth;






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

function enlargebar(){
    if(Iwidth ==190){
        clearInterval(timer);
        Iwidth=Owidth;
    }

    Iwidth++;
    bar.style.width = Iwidth+"px";
}

 
function enlargedrink(){
    if (iwidth ==190){
        clearInterval(timer);
        iwidth=owidth;
    }

    iwidth++;
    drink.style.width= iwidth+'px';
}

function enlargeimage(){

    if (increasewidth ==190){
        clearInterval(timer);
        increasewidth = originalwidth;
    }
    
    increasewidth++;
    products.style.width = increasewidth + 'px';


}


function stickbar(){
    if (window.pageYOffset >= sticky){
        navbar.setAttribute("class","sticky")
    }else{
        navbar.removeAttribute("class","sticky");
    }
}

products.addEventListener('click',()=>{
    timer = setInterval(enlargeimage,10);
})

drink.addEventListener("click",()=>{
    timer = setInterval(enlargedrink,10);
})

bar.addEventListener("click",()=> {
    timer = setInterval(enlargebar,10);
})


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