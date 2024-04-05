<%@ Page Title="Products" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Products.aspx.vb" Inherits="NorthwindDbTest_VB.Products" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <nav aria-label="breadcrumb">
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="./">Home</a></li>
                <li class="breadcrumb-item active" aria-current="page">Products</li>
            </ol>
        </nav>
        <div class="row mt-3">
            <h2 id="title"><%: Title %></h2>
            <asp:UpdatePanel ID="upResults" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="col-12 mt-2">
                        <div class="d-flex">
                            <div class="me-sm-auto py-2">
                                <span class="small"><asp:Literal ID="lblRecordCount" runat="server"></asp:Literal></span>
                            </div>
                            <div class="d-flex flex-wrap justify-content-end" style="grid-column-gap: 1rem;">
                                <div class="form-check mr-3 align-self-center">
                                    <asp:CheckBox ID="chkAvailableOnly" runat="server" Checked="false" Text="Show only available products" />
                                </div>
                                <div>
                                    <div class="input-group">
                                        <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" placeholder="Search by product name..."></asp:TextBox>
                                        <asp:LinkButton ID="btnSearch" runat="server" CssClass="btn btn-secondary">
                                            <i class="bi bi-search"></i>
                                        </asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-12 mt-2">
                        <div class="table-responsive">
                            <asp:GridView ID="gvProducts" runat="server" 
                                AutoGenerateColumns="false" 
                                Width="100%" 
                                CellPadding="3"
                                CssClass="table table-sm table-striped table-light"
                                EmptyDataText = "No products available."
                                OnPreRender="gvProducts_PreRender" 
                                OnDataBound="gvProducts_DataBound">
                                <Columns>
                                    <asp:BoundField DataField="Name" HeaderText="Name" />
                                    <asp:BoundField DataField="QuantityPerUnit" HeaderText="Qty Per Unit" />
                                    <asp:TemplateField HeaderText="Unit Price">
                                        <ItemTemplate>
                                            <%# $"${Eval("UnitPrice")}" %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="UnitsInStock" HeaderText="Units In Stock" />
                                    <asp:TemplateField HeaderText="Total Unit Value">
                                        <ItemTemplate>
                                            <%# $"${Eval("TotalUnitValue")}" %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Available">
                                        <ItemTemplate>
                                            <i class='bi bi-circle-fill <%# If(Convert.ToBoolean(Eval("IsAvailable")), "text-success", "text-danger") %>'></i>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>

