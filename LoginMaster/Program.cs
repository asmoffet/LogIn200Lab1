using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginMaster
{
    public delegate void InputHandler(State state, String args);
    public delegate void StateObs(State state);
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            CredentialsMP model = new CredentialsMP();
            Controller controller = new Controller(model);
            LoginMaster view = new LoginMaster(controller.handleEvents);
            controller.regesterObs(view.DisplayState);
            Application.Run(view);
        }
    }
}
