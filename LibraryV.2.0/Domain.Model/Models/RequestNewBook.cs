﻿using System;
using Domain.Model.Common;

namespace Domain.Model.Models
{
    public class RequestNewBook : Entity
    {
        public virtual User User { get; set; }
        public virtual DateTime RequestDate { get; } = DateTime.Now;
        public virtual string BookName { get; protected set; }
        public virtual string Motivation { get; set; }
        public virtual string Link { get; set; }
        public virtual Urgency UrgencyType { get; set; } = Urgency.WouldBeNice;

        [Obsolete]
        protected RequestNewBook() { }

        public RequestNewBook(User userId, string bookName, string motivation, Urgency urgency )
        {
            if (userId == null)
                throw new ArgumentException("UserId can't be 0");
            if (string.IsNullOrWhiteSpace(bookName))
                throw new ArgumentException("BookName can't be null or whiteSpace");
            if (string.IsNullOrWhiteSpace(motivation))
                throw new ArgumentException("Comment can't be null or whiteSpace");

            User = userId;
            BookName = bookName;
            Motivation = motivation;
            UrgencyType = urgency;
        }
    }
}
