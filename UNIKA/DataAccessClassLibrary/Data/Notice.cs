using System;

namespace BackendClassLibrary.Data
{
    public class Notice
    {
        private int noticeID;
        private string content;
        private string contentEnUs;
        private string contentZhHant;
        private string releasedByEmpID;
        private string releasedBy;
        private DateTime dateDeleted;

        public int getNoticeID()
        {
            return noticeID;
        }

        public void setNoticeID(int noticeID)
        {
            this.noticeID = noticeID;
        }

        public string getContent()
        {
            return content;
        }

        public void setContent(string content)
        {
            this.content = content;
        }

        public string getContentEnUs()
        {
            return contentEnUs;
        }

        public void setContentEnUs(string contentEnUs)
        {
            this.contentEnUs = contentEnUs;
        }

        public string getContentZhHant()
        {
            return contentZhHant;
        }

        public void setContentZhHant(string contentZhHant)
        {
            this.contentZhHant = contentZhHant;
        }

        public string getReleasedByEmpID()
        {
            return releasedByEmpID;
        }

        public void setReleasedByEmpID(string releasedByEmpID)
        {
            this.releasedByEmpID = releasedByEmpID;
        }

        public string getReleasedBy()
        {
            return releasedBy;
        }

        public void setReleasedBy(string releasedBy)
        {
            this.releasedBy = releasedBy;
        }

        public DateTime getDateDeleted()
        {
            return dateDeleted;
        }

        public void setDateDeleted(DateTime dateDeleted)
        {
            this.dateDeleted = dateDeleted;
        }

    }
}
