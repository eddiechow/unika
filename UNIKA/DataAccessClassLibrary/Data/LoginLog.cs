using System;

namespace BackendClassLibrary.Data
{
    public class LoginLog
    {
        private string accountID;
        private string accountName;
        private bool success;
        private bool passwordIncorrect;
        private bool locked;
        private string unlockedByEmpID = null;
        private string unlockedBy = null;
        private bool acStatusTempLock;
        private bool acStatusNonActive;
        private string status = null;
        private DateTime time;
        private string os = null;
        private string browser = null;
        private string ip = null;

        public string getAccountID()
        {
            return accountID;
        }

        public void setAccountID(string accountID)
        {
            this.accountID = accountID;
        }

        public string getAccountName()
        {
            return accountName;
        }

        public void setAccountName(string accountName)
        {
            this.accountName = accountName;
        }

        public bool getSuccess()
        {
            return success;
        }

        public void setSuccess(bool success)
        {
            this.success = success;
        }

        public bool getPasswordIncorrect()
        {
            return passwordIncorrect;
        }

        public void setPasswordIncorrect(bool passwordIncorrect)
        {
            this.passwordIncorrect = passwordIncorrect;
        }

        public bool getLocked()
        {
            return locked;
        }

        public void setLocked(bool locked)
        {
            this.locked = locked;
        }

        public string getUnlockedByEmpID()
        {
            return unlockedByEmpID;
        }

        public void setUnlockedByEmpID(string unlockedByEmpID)
        {
            this.unlockedByEmpID = unlockedByEmpID;
        }

        public string getUnlockedBy()
        {
            return unlockedBy;
        }

        public void setUnlockedBy(string unlockedBy)
        {
            this.unlockedBy = unlockedBy;
        }

        public bool getAcStatusTempLock()
        {
            return acStatusTempLock;
        }

        public void setAcStatusTempLock(bool acStatusTempLock)
        {
            this.acStatusTempLock = acStatusTempLock;
        }

        public bool getAcStatusNonActive()
        {
            return acStatusNonActive;
        }

        public void setAcStatusNonActive(bool acStatusNonActive)
        {
            this.acStatusNonActive = acStatusNonActive;
        }

        public string getStatus()
        {
            return status;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public DateTime getTime()
        {
            return time;
        }

        public void setTime(DateTime time)
        {
            this.time = time;
        }

        public string getOs()
        {
            return os;
        }

        public void setOs(string os)
        {
            this.os = os;
        }

        public string getBrowser()
        {
            return browser;
        }

        public void setBrowser(string browser)
        {
            this.browser = browser;
        }

        public string getIp()
        {
            return ip;
        }

        public void setIp(string ip)
        {
            this.ip = ip;
        }

    }
}
