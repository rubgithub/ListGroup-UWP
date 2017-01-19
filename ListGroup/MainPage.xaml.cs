using System.Collections.Generic;
using System.Linq;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ListGroup
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage 
    {
        public MainPage()
        {
            this.InitializeComponent();

            var contactList = new List<Contact>
            {
                new Contact {FirstName = "Abravanel", LastName = "Santos"},
                new Contact {FirstName = "Barbosa", LastName = "Sousa"},
                new Contact {FirstName = "Bruna", LastName = "Maria"},
                new Contact {FirstName = "Bruna", LastName = "Lombardi"},
                new Contact {FirstName = "Carlos", LastName = "Alberto"}

            };

            var grupo = from act in contactList.OrderBy(c => c.FirstName).ThenBy(c => c.LastName)
                group act by act.Inicial
                into grp
                orderby grp.Key
                select grp;

            Cvs.Source = grupo;            
        }
    }
}
