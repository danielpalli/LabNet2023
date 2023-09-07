import "./style.css";

document.querySelector("#app").innerHTML = `
  <div class="container mx-auto">
    <button id="reset" type="button" class="bg-red-500 p-2 m-6 rounded-sm shadow-md text-white">
      Reiniciar!
    </button>
    <h1 class="font-bold text-center text-3xl">Adivinar el Número! <spam class="bg-cyan-400 rounded-3xl shadow-md px-4 py-1">(entre 1 y 20)</spam></h1>
    <hr class="my-10">

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
            <p class="w-1/2">Score:</p>
            <p>Highscore:</p>
          </div>
          <hr>
      </div>

    </div>
  </div>
`;

const btnCheck = document.getElementById("checkButton");
const inputValue = document.getElementById("value");
let numberToGuess = Math.floor(Math.random() * 20) + 1;
const result = document.getElementById("result");
const reset = document.getElementById("reset");

const enviarResultado = () => {
  if (inputValue.value == ""){
    alert("Ingrese un numero");
  }
  console.log(numberToGuess);
  if (inputValue.value == numberToGuess){
    result.innerHTML = "Correcto!";
  }
}

btnCheck.addEventListener("click", enviarResultado);
reset.addEventListener("click", () => {
  numberToGuess = Math.floor(Math.random() * 20) + 1;
  inputValue.value = "";
  result.innerHTML = "?";
});

