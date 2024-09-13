namespace LinkedList
{
  public partial class Form1 : Form
  {
    LinkedList list = new LinkedList();
    public Form1()
    {
      InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      //if the value exists in the linked list, display a message box
      if (list.Contains(int.Parse(txtValue.Text)))
      {
        MessageBox.Show("Value already exists in the linked list");
        return;
      }
      //Add the value to the linked list
      Node node = new Node(int.Parse(txtValue.Text) , txtName.Text, txtPhoneNumber.Text);
      list.Add(node);//int.Parse(txtValue.Text));
      //Display the linked list in a message box
      MessageBox.Show(list.ToString());


    }

    private void btnContains_Click(object sender, EventArgs e)
    {
      //if the value in txtValue exists in the linked list, display a message box
      if (list.Contains(int.Parse(txtValue.Text)))
      {
        MessageBox.Show("Value exists in the linked list");
      }
      else
      {
        MessageBox.Show("Value does not exist in the linked list");
      }
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      //if the value in txtValue exists in the linked list, remove it
      if (list.Contains(int.Parse(txtValue.Text)))
      {
        list.Remove(int.Parse(txtValue.Text));
        //Display the linked list in a message box
        MessageBox.Show(list.ToString());
      }
      else
      {
        MessageBox.Show("Value does not exist in the linked list");
      }
    }
  }
}
