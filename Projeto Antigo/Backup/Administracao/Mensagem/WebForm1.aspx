<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    
    <script language="javascript">window.resizeTo(300, 200)</script>

<script type="text/javascript">
    var oMyObject = window.dialogArguments;
    var Texto = oMyObject.Texto;

    function Abre() {
        form1.Texto.value = Texto;
    }

    function OK() {
        var vReturnValue = new Object();
        vReturnValue.Texto = document.getElementById("Texto").value;

        window.returnValue = vReturnValue;
        window.close();
    }
        
</script>    
</head>
<body onload="Abre();">
    <form id="form1" runat="server" 
    style="z-index: auto; margin: auto; padding: inherit; height: 58px; width: 401px;">
    <div style="height: 32px; width: 286px">
      <input name="Texto" id="Texto" type="text"  >
      <input name="button" type="button" value="-----OK-----" onClick="OK();" >
    <br />
    </div>
    </form>
</body>
</html>
