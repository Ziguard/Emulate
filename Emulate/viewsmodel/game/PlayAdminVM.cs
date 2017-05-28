using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emulate.views.game;

namespace Emulate.viewsmodel
{
    public class PlayAdminVM
    {
        private PlayViews playViews;

        public PlayAdminVM(PlayViews playViews)
        {
            this.playViews = playViews;
            InitLUC();
            InitLUC();
            InitActions();
        }

        private void InitActions()
        {
            
        }

        private void InitLUC()
        {
            throw new NotImplementedException();
        }
    }
}
