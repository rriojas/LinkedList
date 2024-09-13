using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
  internal class Node
  {
    public int Value { get; set; }
    //Name  
    public string Name { get; set; }
    //Phone number
    public string PhoneNumber { get; set; }

    public Node Next { get; set; }

    public Node()
    {
      Value = 0;
      Name = "";
      PhoneNumber = "";
      Next = null;
    }
    public Node(int value, string name, string phoneNumber)
    {
      Value = value;
      Name = name;
      PhoneNumber = phoneNumber;
      Next = null;
    }
    public override string ToString()
    {
      return Value.ToString() + " - " + Name + " " + PhoneNumber;
    }
  }
}
