﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LanguageFeatures.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Language Features</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h2>Language Features</h2>
        <p><%=GetMessage()%></p>
    </div>
    </form>
</body>
</html>
