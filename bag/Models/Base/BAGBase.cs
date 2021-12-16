namespace bag.Models.Base
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BAGBase : DbContext
    {        
        public virtual DbSet<article> articles { get; set; }
        public virtual DbSet<feedback> feedbacks { get; set; }
        public virtual DbSet<savingModule> savingModules { get; set; }
        public virtual DbSet<module> modules { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<optionsModule> optionsModules { get; set; }
        public virtual DbSet<optionsBlock> optionsBlocks { get; set; }
        public virtual DbSet<page> pages { get; set; }
        public virtual DbSet<photo> photos { get; set; }
        public virtual DbSet<photoimg> photoimgs { get; set; }
        public virtual DbSet<pageModule> pageModules { get; set; }
        public virtual DbSet<propertyTemplate> propertyTemplates { get; set; }
        public virtual DbSet<saveProperty> saveProperties { get; set; }
        public virtual DbSet<savePropertyOptionsBlock> savePropertyOptionsBlocks { get; set; }
        public virtual DbSet<site> sites { get; set; }
        public virtual DbSet<smtpOption> smtpOptions { get; set; }
        public virtual DbSet<template> templates { get; set; }
        public virtual DbSet<templatesOptionsBlock> templatesOptionsBlocks { get; set; }
        public virtual DbSet<userField> userFields { get; set; }
        public virtual DbSet<userImage> userImages { get; set; }
        public virtual DbSet<video> videos { get; set; }
        public virtual DbSet<videoList> videolists { get; set; }
    }
}
