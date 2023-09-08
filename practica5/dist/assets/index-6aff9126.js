(function(){const c=document.createElement("link").relList;if(c&&c.supports&&c.supports("modulepreload"))return;for(const e of document.querySelectorAll('link[rel="modulepreload"]'))a(e);new MutationObserver(e=>{for(const t of e)if(t.type==="childList")for(const l of t.addedNodes)l.tagName==="LINK"&&l.rel==="modulepreload"&&a(l)}).observe(document,{childList:!0,subtree:!0});function v(e){const t={};return e.integrity&&(t.integrity=e.integrity),e.referrerPolicy&&(t.referrerPolicy=e.referrerPolicy),e.crossOrigin==="use-credentials"?t.credentials="include":e.crossOrigin==="anonymous"?t.credentials="omit":t.credentials="same-origin",t}function a(e){if(e.ep)return;e.ep=!0;const t=v(e);fetch(e.href,t)}})();document.querySelector("#app").innerHTML=`
  <div id="backgroundStatus" class="container mx-auto h-screen">
    <button id="reset" type="button" class="bg-red-500 p-2 m-6 rounded-sm shadow-md text-white">
      Reiniciar!
    </button>
    <h1 class="font-bold text-center text-3xl">Adivinar el Número! <spam class="bg-cyan-400 rounded-3xl shadow-md px-4 py-1">(entre 1 y 20)</spam></h1>
    <div class="my-10 relative">
    <hr>
    <div class="absolute inset-0 flex items-center justify-center">
      <p id="valueActive" class="bg-gray-200 rounded-full p-7">
        ?
      </p>
      </div>
    </div>
    <div class="flex w-full h-[calc(100vh-500px)]">

      <div class="w-1/2">
        <div class="flex flex-col justify-center items-center h-[100%]">
          <input id="value" type="number" class="border border-gray-700 rounded-sm shadow-sm p-4 text-center" placeholder="Ingrese un numero" />
          <button id="checkButton" type="button" class="bg-green-600 rounded-sm p-2 text-white mt-8">Probar!</button>
        </div>
      </div>

      <div class="w-1/2 py-5">
          <p class="my-4" id="result">?</p>
          <hr>
          <div class="flex my-5">
            <p class="w-1/2">Score: <span id="score">20</span></p>
            <p>Highscore: <span id="highScore">0</span></p>
          </div>
          <hr>
      </div>

    </div>
  </div>
`;const u=document.getElementById("checkButton"),n=document.getElementById("value"),o=document.getElementById("result"),h=document.getElementById("reset"),d=document.getElementById("score"),m=document.getElementById("highScore"),f=document.getElementById("backgroundStatus"),p=document.getElementById("valueActive");let i=Math.floor(Math.random()*20)+1,r=20,s=0;const y=()=>{if(n.value==""||n.value<1||n.value>20){alert("Ingrese un numero entre 1 y 20");return}if(p.innerHTML=n.value,n.value==i){o.innerHTML="Numero Correcto!",f.style.backgroundColor="green",u.disabled=!0,r>s&&(s=r,m.innerHTML=s);return}if(r==0){o.innerHTML="Perdiste!",r=0,d.innerHTML=r;return}r-=1,d.innerHTML=r,n.value>i?o.innerHTML="Muy Alto!":n.value<i&&(o.innerHTML="Muy Bajo!")},g=()=>{r>s&&(s=r,m.innerHTML=s),u.disabled=!1,p.innerHTML="?",f.style.backgroundColor="white",i=Math.floor(Math.random()*20)+1,n.value="",o.innerHTML="?",r=20,d.innerHTML=r};u.addEventListener("click",y);h.addEventListener("click",g);
