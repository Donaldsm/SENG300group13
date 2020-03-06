<%@ Page Language="C#" %>

<!DOCTYPE html>
<script runat="server">

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

const formToJSON = elements => [].reduce.call(elements, (data, element) => {
  data[element.name] = element.value;
  return data;
}, {});

    const handleFormSubmit = event => {
     event.preventDefault();

  const data = {};

  const dataContainer = document.getElementsByClassName('results__display')[0];
 
  dataContainer.textContent = JSON.stringify(data, null, "  ");
 
};

const form = document.getElementsByClassName('contact-form')[0];
form.addEventListener('submit', handleFormSubmit);



</script>


<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">   
        <p>
            Award Title&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Award Title" runat="server" Height="25px"></asp:TextBox>
        </p>
        <p>
            Award Amount&nbsp;&nbsp;
            <asp:TextBox ID="Award Amount" runat="server" Height="25px"></asp:TextBox>
        </p>
        <p>
            Number of Awards
            <asp:TextBox ID="Number of Awards" runat="server" Height="25px"></asp:TextBox>
        </p>
        <p>
            Company
            <asp:TextBox ID="Company" runat="server" Height="25px"></asp:TextBox>
        </p>
        <p>
            Duration
            <asp:TextBox ID="Duration" runat="server" Height="25px"></asp:TextBox>
        </p>
        <p>
            Deadline
            <asp:TextBox ID="Deadline" runat="server" Height="25px"></asp:TextBox>
        </p>
        <p>
            Scope (department wide, university wide etc.)&nbsp;
            <asp:TextBox ID="Scope" runat="server" Height="25px"></asp:TextBox>
        </p>
        <p>
            GPA Requirements
            <asp:TextBox ID="GPA requirements" runat="server" Height="25px"></asp:TextBox>
        </p>
        <p>
            Year Restrictions(ex. Only for first years)&nbsp;
            <asp:TextBox ID="Year Restrictions" runat="server" Height="25px"></asp:TextBox>
        </p>
        <p>
            Candidate Restrictions
            <asp:TextBox ID="Candidate Restrictions" runat="server" Height="25px"></asp:TextBox>
        </p>
        <p>
            Full-Time Status
            <asp:TextBox ID="Full-Time Status" runat="server" Height="25px"></asp:TextBox>
        </p>
        <p>
            Supplementary Status
            <asp:TextBox ID="Supplementary Status" runat="server" Height="25px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Text="Submit" />
    </form>
</body>
</html>
