<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehicleStartUp.aspx.cs" Inherits="FormApps.VehicleStartUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vehicle Start-Up</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">

    <link rel="stylesheet" href="css/main.css"/>
  <%--<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">--%>
  <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>--%>
<%--  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>--%>
</head>
<body>
    
<div class="container">
  <h2>Vehicle Start-up - the Circle Check</h2>
    <form id="form1" runat="server">
       <h3>What is a Circle Check</h3>
       <p>A circle check is a visual and audible inspection of a vehicle or mobile equipment. The circle check allows operators to look and listen for any areas of concern. If a concern is noted, do not use that vehicle or equipment until the issue has been addressed.   <br/> <br/>
           A circle check should be completed at the start of the shift or before a new operator takes control of the vehicle.  Many workplaces will provide a pre-operational checklist logbook in each vehicle. This logbook is a recordkeeping tool that records the date, operator, and the elements that were checked before each use.</p>
       <h3>What should I check before operating a vehicle? </h3>
       <p> Adjust seat and controls.
            Make sure you have your driver's license on you as well as any training certificates that may be required.
            Fasten seat belt if tractor/loader is equipped with roll-over protection structure (ROPS).
            Below is a sample inspection checklist. Always adapt sample checklists to meet the needs of your organization, the equipment specifications, and any legislative requirements.</p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="lblMsg" runat="server" EnableViewState="False" Font-Size="Medium" ForeColor="Red"></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="BtnContinue" />
            </Triggers>
        </asp:UpdatePanel>
     
         <div class="form-group">
            <label for="vehicle">Vehicle or Equipment Inspected:</label>
            <input type="text" class="form-control" id="vehicle" placeholder="Enter Vehicle or Equipment Inspected" name="vehicle" maxlength="90"/>
        </div>

        <div class="form-row form-group">
            <div class="form-holder">
              <label for="date">Date:</label>
              <input type="text" class="form-control" id="date" placeholder="" name="date" maxlength="10" value="datetime.now()"/>
            </div>
              <div class="form-holder">
              <label for="odometer">Odometer:</label>
              <input type="text" class="form-control" id="odometer" placeholder="Enter Odometer" name="odometer" maxlength="20"/>
            </div>
         </div>
        <div class="form-group">
            <label for="operator">Operator:</label>
            <input type="text" class="form-control" id="operator" placeholder="Enter Operator" name="operator" maxlength="50"/>
        </div>


         <div class="radiobuttonlist">
              <asp:RadioButton ID="radiobutton1"  runat="server" GroupName="Line1" Text="Ok" />
              <asp:RadioButton ID="radiobutton2"  runat="server" GroupName="Line1" Text="Not Ok" Checked="True"/>&nbsp;
              <label runat="server" id="description1" class="small">Parking Brake -holds against slight acceleration</label> 
            </div>
         <div class="radiobuttonlist">
              <asp:RadioButton ID="radiobutton3"  runat="server" GroupName="Line2" Text="Ok"/>
              <asp:RadioButton ID="radiobutton4"  runat="server" GroupName="Line2" Text="Not Ok" Checked="True"/>&nbsp;
              <label runat="server" id="description2" class="small">Foot Brake - holds, stops vehicle smoothly</label> 
          </div>
               <div class="radiobuttonlist">
              <asp:RadioButton ID="radiobutton5"  runat="server" GroupName="Line3" Text="Ok"/>
              <asp:RadioButton ID="radiobutton6"  runat="server" GroupName="Line3" Text="Not Ok" Checked="True"/>&nbsp;
              <label runat="server" id="description3" class="small">Clutch and Gearshift - shifts smoothly without jumping or jerking</label> 
          </div>
          <div class="radiobuttonlist">
              <asp:RadioButton ID="radiobutton7"  runat="server" GroupName="Line4" Text="Ok" />
              <asp:RadioButton ID="radiobutton8"  runat="server" GroupName="Line4" Text="Not Ok" Checked="True"/>&nbsp;
              <label runat="server" id="description4" class="small">Steering - moves smoothly; no "play"</label> 
          </div>
          <div class="radiobuttonlist">
              <asp:RadioButton ID="radiobutton9"  runat="server" GroupName="Line5" Text="Ok" />
              <asp:RadioButton ID="radiobutton10"  runat="server" GroupName="Line5" Text="Not Ok" Checked="True"/>&nbsp;
              <label runat="server" id="description5" class="small">Lights - headlights, warning lights, and turn signals operational</label> 
          </div>
   <%-- <button type="button" class="btn btn-default" formmethod="get">Continue</button>--%>
        <div class="input-group">
               <asp:Button ID="BtnContinue"  isDefault="True" runat="server" OnClick="BtnContinue_Click" Text="Submit" />
              </div>
            </form>
        </div>
 <!-- JQUERY STEP -->
  <script src="js/core.js" type="text/javascript"></script>
</body>
</html>
