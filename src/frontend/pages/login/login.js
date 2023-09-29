//validação login

const form = document.getElementById("loginForm");
const username = document.getElementById("username");
const password = document.getElementById("password");

document.getElementById("loginForm").addEventListener("submit", (event) => {
  event.preventDefault(); // impede envio

  //validação dos campos vazios
  if (username.value === "" && password.value === "") {
    alert("Por favor, preencha ambos os campos de login.");
  } else if (username.value === "") {
    alert("Por favor, preencha o campo de usuário.");
  } else if (password.value === "") {
    alert("Por favor, preencha o campo de senha.");
  }
  console.log("Nome de Usuário:", username.value);
  console.log("Senha:", password.value);
});

//simulação de sucesso

// if (username === "username" && password === "password") {
//   alert("Login bem-sucedido!");
// } else {
//   alert("Login falhou");
// }
