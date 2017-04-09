using Emulate.views.administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulate.viewsmodel
{
    public class PersonnageAdminVM
    {
        //private Zoo currentZoo;
        //private ZooAdmin zooAdmin;
        //private Group currentGroup;

        private PersonnageAdmin personnageAdmin;

        internal void LoadPersonnageAdmin(PersonnageAdmin personnageAdmin)
        {
            throw new NotImplementedException();
        }


        //private MySQLManager<Zoo> zooManager = new MySQLManager<Zoo>();
        //private MySQLZooManager zooLinkManager = new MySQLZooManager();
        //private MySQLZooManager zooManager = new MySQLZooManager();
        //private AddressAdmin addressAdmin;

        //private StructureAdmin structureAdmin;
        //private ScheduleAdmin scheduleAdmin;
        //private AnimalAdmin animalAdmin;
        //private EmployeeAdmin employeeAdmin;
        //private const String RegexName = "^[a-zA-Z]+$-*"; //Work with method checkRegex()
        //private readonly string[] ListName = { "Last name", "First name", "Manager last name", "Manager first name" }; //Work with method checkRegexTxtBName()
        //List<System.Windows.Controls.TextBox> listTxtB = new List<System.Windows.Controls.TextBox>();
        //private Employee currentEmployee;
        //private MySQLManager<Employee> employeeManager = new MySQLManager<Employee>();

        //private AddressAdmin addressAdmin;
        //private MySQLStructureManager structureLinkManager = new MySQLStructureManager();
        //private MySQLManager<Structure> structureManager = new MySQLManager<Structure>();


        //private Structure currentStructure;
        //ListStructureUserControl newListControl;
        //List<Structure> allStructuresInsert = new List<Structure>();


        public object UCZooList { get; private set; }

        public PersonnageAdminVM(PersonnageAdmin personnageAdmin)
        {
            this.personnageAdmin = personnageAdmin;
            //zooManager

            //InitUC();
            //InitLUC();
            //InitActions();
        }

        private void InitUC()
        {
            throw new NotImplementedException();
        }

        private void InitActions()
        {
            throw new NotImplementedException();
        }

        private void InitLUC()
        {
            throw new NotImplementedException();
        }
    }
}
