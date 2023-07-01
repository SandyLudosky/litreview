

html {
    background-size: 40%;
    background-repeat: repeat;
  }

  .container {
    display: flex;
    flex-direction: column;
    justify-content: space-around;
    padding: 2rem;
  }
  .card {
    padding: 10rem;
    border: 1px solid #000;
    border-radius: 4px;
    width: 50%;
  }


  h1 {
    font-size: 3em;
  }

  a {
    color: #000;
    color: #000;
    text-decoration: none;
    transition: color 0.5s;
  }
  a:hover {
    color: #c49b38;
  }

  p, span, ul {
    color: #000;
  }

  .login {
    display: flex;
    width: 100%;
    justify-content: space-around;
  }
  .signup {
    display: flex;
    flex-direction: column;
    align-items: center;
  }

  .form {
    background-color: rgba(255, 255, 255, 0.5);
    display: flex;
    align-items: center;
    flex-direction: column;
  }
  .form textarea {
    font-family: "typewriter_condensedregular";
    color: #000;
    width: 100%;
  }
  .form input, .form label {
    display: block;
    color: #000;
  }
  .form input {
    width: 100%;
    height: 35px;
  }
  .form__signup div {
    display: flex;
    justify-content: flex-end;
  }
  .form__signup p {
    margin: 0,
    padding: 10px
  }
  .form__signup .btn, .form__signup button  {
    width: auto;
    height: 35px;
    padding: 0 12px;
  }
  .form__ticket form, .form__ticket textarea {
    width: 100%!important;
  }
  .form label {
    font-weight: bold;
  }
  .form .helptext, .form ul {
    color: #c49b38;
    font-size: small;
  }

  .btn {
    display: block;
    color: #000;
    font-size: medium;

    padding: 12px;
    font-weight: bold;
    background-color: rgba(255, 255, 255, 0.5);
    border: solid 1px #000;
    border-radius: 4px;
    transition: all 0.3s;
    margin: 2px 2px 2px 2px;
    float: right;
  }
  .btn:hover {
    cursor: pointer;
    color: #c49b38;
  }

  .logo {
    display: inline-block;
    width: 80px;
    height: 80px;
  }

  header {
    display: flex;
    justify-content: space-between;
    align-items: center;
  }
  header .header {
    border: 1px solid #000;
    display: flex;
    width: 100%;
    text-align: center;
    justify-content: space-between;
    padding: 0 1rem;
  }

  .navigation ul {
    display: flex;
    justify-content: space-between;
    align-items: center;
    list-style: none;

  }

  .navigation li {
    margin: 0 1rem;
  }
  .main {
    display: flex;
    flex-direction: column;
    align-items: center;
    flex: 0 0 60%;
  }
  .home {
    display: flex;
    justify-content: space-around;
  }

  .controls {
    color: #000;
    display: flex;
    flex-direction: column;
  }
  .mr-5 {
    margin-right: 5rem;
  }