﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiseaseSetupUI.aspx.cs" Inherits="CommunityMedicineSystem.Web.HeadOffice.DiseaseSetupUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Disease Setup - Community Medicine System</title>
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />

    <%--<link href="assets/css/bootstrap.css" rel="stylesheet" />--%>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../assets/css/font-awesome.min.css" rel="stylesheet" />

    <link href="../assets/css/style-slide.css" rel="stylesheet" />
    <link href="../assets/css/custom.css" rel="stylesheet" />

    <link href="../assets/css/style.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server" class="form-horizontal">

        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <%--<a class="navbar-brand" href="#">COMMUNITY MEDICINE</a>--%>
                    <img class="img-circle" src="../assets/img/team/logo.png" alt="">
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav navbar-right">
                        <li><a href="/index.aspx">HOME</a></li>
                        <li><a href="/Center/CenterLoginUI.aspx">CENTER</a></li>
                        <li><a href="/HeadOffice/MedicineSetupUI.aspx">MEDICINE SETUP</a></li>
                        <li><a href="#">DISEASE SETUP</a></li>
                        <li><a href="/HeadOffice/CreateNewCenterUI.aspx">CREATE CENTER</a></li>
                        <li><a href="/HeadOffice/MedicineStockInCenterUI.aspx">MEDICINE CENTER</a></li>
                    </ul>
                </div>

            </div>
        </div>

        <div id="about-section">
            <div class="container">
                <div class="row main-top-margin text-center">
                    <div class="col-md-8 col-md-offset-2 col-sm-12">
                        <h2>Welcome To Head Office</h2>
                        <hr />
                        <h4>
                            <strong>Disease Setup</strong>
                        </h4>
                    </div>
                </div>
            </div>
        </div>

        <div class="form-group">
            <label for="inputName" class="col-sm-2 control-label">Disease Name</label>
            <div class="col-sm-4">
                <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control" placeholder="Name"></asp:TextBox>
            </div>
        </div>


        <div class="form-group">
            <label for="inputDescription" class="col-sm-2 control-label">Description</label>
            <div class="col-sm-4">
                <asp:TextBox ID="descriptionTextBox" runat="server" CssClass="form-control" placeholder="Description"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <label for="inputTreatementProcedure" class="col-sm-2 control-label">Treatement Procedure</label>
            <div class="col-sm-4">
                <asp:TextBox ID="treatementProcedureTextBox" runat="server" CssClass="form-control" placeholder="Treatement Procedure"></asp:TextBox>
            </div>
        </div>
        
        <div class="form-group">
            <label for="inputPreferredDrug" class="col-sm-2 control-label">Preferred Drug</label>
            <div class="col-sm-4">
                <asp:TextBox ID="preferredDrugTextBox" runat="server" CssClass="form-control" placeholder="Preferred Drug"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
                <asp:Button ID="saveButton" runat="server" CssClass="btn btn-info" Text="Save" OnClick="saveButton_Click" />
            </div>
        </div>

        <asp:Label ID="msgLabel" runat="server"></asp:Label>

        

        <div class="text-center" id="social">

            <a href="#"><i class="fa fa-facebook-square fa-3x color-facebook"></i></a>
            <a href="#"><i class="fa fa-twitter-square fa-3x color-twitter"></i></a>
            <a href="#"><i class="fa fa-google-plus-square fa-3x color-google-plus"></i></a>
            <a href="#"><i class="fa fa-linkedin-square fa-3x color-linkedin"></i></a>
            <a href="#"><i class="fa fa-pinterest-square fa-3x color-pinterest"></i></a>

        </div>

        <div id="footer">
            <div class="container">
                <div class="row ">
                    &copy; 2015 www.enginbox.com | All Right Reserved
                </div>
            </div>
        </div>

        <script src="../assets/js/jquery.js"></script>
        <%--<script src="assets/js/bootstrap.min.js"></script>--%>
        <script src="../Scripts/bootstrap.min.js"></script>
        <script src="../assets/js/modernizr.custom.79639.js"></script>
        <script src="../assets/js/jquery.ba-cond.min.js"></script>
        <script src="../assets/js/jquery.slitslider.js"></script>
        <script src="../assets/js/custom.js"></script>

    </form>
</body>

</html>

