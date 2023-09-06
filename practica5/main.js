import './style.css'
document.querySelector('#app').innerHTML = `
  <div class="container mx-auto">
    <button class="bg-red-500 p-2 m-6 rounded-sm shadow-md text-white">
      Reiniciar!
    </button>
    <h1 class="font-bold text-center text-3xl">Adivinar el Número! <spam class="bg-cyan-400 rounded-3xl shadow-md px-4 py-1">(entre 1 y 20)</spam></h1>
    <hr>
    <div>
      <form>
        <input placeholder="Ingrese un numero" />
        <button>Probar!</button>
      </form>

      <div>
        status
        <hr>
        status
        <hr>
      </div>
    </div>
  </div>
`
