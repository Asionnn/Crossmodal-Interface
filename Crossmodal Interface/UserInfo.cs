using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossmodal_Interface
{
    class UserInfo
    {
		private string firstName;
		private string lastName;
		private int visual;
        private int auditory;
        private int tactile;
        public UserInfo(string firstName, string lastName, int v, int a, int t)
        {
            this.firstName = firstName;
			this.lastName = lastName;
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
		public string getFirstName()
		{
			return this.firstName;
		}
		public string getLastName()
		{
			return this.lastName;
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
