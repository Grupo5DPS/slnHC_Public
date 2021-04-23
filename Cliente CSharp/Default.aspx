<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cliente_CSharp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  

<body>
    <br />
    <header class='colorCabecera' style="height: 318px">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="../Content/style.css">
        <!-- Navbar -->
      
        
        <div class="p-5 text-center bg-light imagen" style="height: 319px" >
            <br />
            <br />
          <h1 class="mb-3" style="height: 64px">Sistema de Registro de Historias Clinicas</h1>
          <h4 class="mb-3">En busca de una mejor gestión y compartir de la informacion</h4>
          <a class="btn btn-primary" href="https://campus.uandina.edu.pe/login/index.php" role="button">Universidad Andina del Cusco</a>
        </div>
        
      </header>
     <br />

<!-- Se construira El cuerpo de la pagina a base de targetas con bootstrsp -->
<div class="container" style="margin-top: 56px">
    <div class="row">
        <div class="col-sm-6" style="left: 0px; top: -14px; height: 92px">
          <div class="card">
            <div class="card-body">
              <h5 class="card-title">Consulte su historial clínico </h5>
              <p class="card-text">Brindamos tratamiento centrado en el paciente, excelencia clínica y un nivel avanzado de atención que no está disponible en ningún otro lugar del Perú.</p>
              <a href="#" class="btn btn-primary">Consulta tu historial</a>
            </div>
          </div>
        </div>
        <div class="col-sm-6" style="left: 0px; top: 4px; height: 81px">
          <div class="card">
            <div class="card-body">
              <h5 class="card-title">Distintos Centros Medicos afiliados</h5>
              <p class="card-text">Los diferentes centros de salud se encuentran en constante implementación con el fín de unificar la información que es de vital importancia y aqui encontrará lugar para su atención</p>
              <a href="#" class="btn btn-primary">Visita algunos Centros</a>
            </div>
          </div>
        </div>
    </div>
    <br>
    <div class="row">
        <div class="col-sm-12">
          <div class="card">
            <div class="card-body">
              <h5 class="card-title">Brindamos información transparente</h5>
              <p class="card-text">Damos a conocer la información de forma continua y cada vez que sea posible</p>
              <a href="#" class="btn btn-primary">Compartimos Información</a>
            </div>
          </div>
        </div>
    </div>
</div>
    
</body>
</asp:Content>
