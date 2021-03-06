﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing.Imaging;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;

namespace HM_Projecto.Models
{
    public class Post
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int person_id;

        public int Person_ID
        {
            get { return person_id; }
            set { person_id = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private ImageFormat image;

        public ImageFormat Image
        {
            get { return image; }
            set { image = value; }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private string tag;

        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }

        private int rep_plus;

        public int Rep_plus
        {
            get { return rep_plus; }
            set { rep_plus = value; }
        }

        private int rep_minus;

        public int Rep_minus
        {
            get { return rep_minus; }
            set { rep_minus = value; }
        }

        public virtual Person Person { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}