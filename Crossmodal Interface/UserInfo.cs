using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossmodal_Interface
{
    class UserInfo
    {
        private string id;
        private int visual;
        private int auditory;
        private int tactile;
        public UserInfo(string i, int v, int a, int t)
        {
            this.id = i;
            this.visual = v;
            this.auditory = a;
            this.tactile = t;
        }
        public int getVisualIntensity()
        {
            return this.visual;
        }
        public int getAuditoryIntensity()
        {
            return this.auditory;
        }
        public int getTactileIntensity()
        {
            return this.tactile;
        }
        public string getId()
        {
            return this.id;
        }
        public void setVisualIntensity(int value)
        {
            this.visual = value;
        }
        public void setAuditoryIntensity(int value)
        {
            this.auditory = value;
        }
        public void setTactileIntensity(int value)
        {
            this.tactile = value;
        }
    }
}
