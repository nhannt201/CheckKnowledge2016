Public Class home_v2
    Private Sub imgindex_Click(sender As Object, e As EventArgs) Handles imgindex.Click
        End
    End Sub

    Private Sub home_v2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tNode As TreeNode
        tNode = list_last.Nodes.Add("THCS")

        list_last.Nodes(0).Nodes.Add("Lớp 6")
        list_last.Nodes(0).Nodes(0).Nodes.Add("Ngữ Văn")
        list_last.Nodes(0).Nodes(0).Nodes.Add("Lịch Sử")
        list_last.Nodes(0).Nodes(0).Nodes.Add("Địa Lí")
        list_last.Nodes(0).Nodes(0).Nodes.Add("Sinh Học")
        list_last.Nodes(0).Nodes(0).Nodes.Add("Công Nghệ")
        list_last.Nodes(0).Nodes(0).Nodes.Add("Giáo Dục Công Dân")
        list_last.Nodes(0).Nodes(0).Nodes.Add("Vật Lý")
        list_last.Nodes(0).Nodes(0).Nodes.Add("Tiếng Anh")

        list_last.Nodes(0).Nodes.Add("Lớp 7")
        list_last.Nodes(0).Nodes(1).Nodes.Add("String Tutorial")
        list_last.Nodes(0).Nodes(1).Nodes.Add("Excel Tutorial")

        list_last.Nodes(0).Nodes.Add("Lớp 8")
        list_last.Nodes(0).Nodes(2).Nodes.Add("ADO.NET")
        list_last.Nodes(0).Nodes(2).Nodes(0).Nodes.Add("Dataset")

        list_last.Nodes(0).Nodes.Add("Lớp 9")
        list_last.Nodes.Add("THPT")
        list_last.Nodes(1).Nodes.Add("Lớp 10")

        list_last.Nodes(1).Nodes.Add("Lớp 11")

        list_last.Nodes(1).Nodes.Add("Lớp 2")

        list_last.Nodes.Add("Khác")
    End Sub

    Private Sub list_last_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles list_last.AfterSelect
        lb_path.Text = list_last.SelectedNode.FullPath
    End Sub
End Class