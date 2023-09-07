import "./style.css";


document.querySelector("#app").innerHTML = `
  <div class="container mx-auto">
    <button class="bg-red-500 p-2 m-6 rounded-sm shadow-md text-white">
      Reiniciar!
    </button>
    <h1 class="font-bold text-center text-3xl">Adivinar el Número! <spam class="bg-cyan-400 rounded-3xl shadow-md px-4 py-1">(entre 1 y 20)</spam></h1>
    <hr class="my-10">

    <div class="flex w-full h-[calc(100vh-500px)]">

      <form class="w-1/2">
        <div class="flex flex-col justify-center items-center h-[100%]">
          <input type="number" class="border border-gray-700 rounded-sm shadow-sm p-4 text-center" placeholder="Ingrese un numero" />
          <button class="bg-green-600 rounded-sm p-2 text-white mt-8">Probar!</button>
        </div>
      </form>

      <div class="w-1/2 py-5">
          <p class="my-4">result</p>
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
