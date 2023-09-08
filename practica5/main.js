import "./style.css";

document.querySelector("#app").innerHTML = `
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
`;

const btnCheck = document.getElementById("checkButton");
const inputValue = document.getElementById("value");
const result = document.getElementById("result");
const reset = document.getElementById("reset");
const score = document.getElementById("score");
const highScore = document.getElementById("highScore");
const backgroundStatus = document.getElementById("backgroundStatus");
const valueActive = document.getElementById("valueActive");

let numberToGuess = Math.floor(Math.random() * 20) + 1;
let valueScore = 20;
let highScoreValue = 0;

const enviarResultado = () => {
  if (inputValue.value == "" || inputValue.value < 1 || inputValue.value > 20) {
    alert("Ingrese un numero entre 1 y 20");
    return;
  }

  valueActive.innerHTML = inputValue.value;

  if (inputValue.value == numberToGuess) {
    result.innerHTML = "Numero Correcto!";
    backgroundStatus.style.backgroundColor = "green";
    btnCheck.disabled = true;

    if (valueScore > highScoreValue) {
      highScoreValue = valueScore;
      highScore.innerHTML = highScoreValue;
    }
    return;
  }

  if (valueScore == 0) {
    result.innerHTML = "Perdiste!";
    valueScore = 0;
    score.innerHTML = valueScore;
    return;
  }

  valueScore -= 1;
  score.innerHTML = valueScore;

  if (inputValue.value > numberToGuess) {
    result.innerHTML = "Muy Alto!";
  } else if (inputValue.value < numberToGuess) {
    result.innerHTML = "Muy Bajo!";
  }
};

const resetGame = () => {
  if (valueScore > highScoreValue) {
    highScoreValue = valueScore;
    highScore.innerHTML = highScoreValue;
  }
  btnCheck.disabled = false;
  valueActive.innerHTML = "?";
  backgroundStatus.style.backgroundColor = "white";
  numberToGuess = Math.floor(Math.random() * 20) + 1;
  inputValue.value = "";
  result.innerHTML = "?";
  valueScore = 20;
  score.innerHTML = valueScore;
};

btnCheck.addEventListener("click", enviarResultado);
reset.addEventListener("click", resetGame);
