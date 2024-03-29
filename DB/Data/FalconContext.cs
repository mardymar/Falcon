﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DB.Models;

namespace DB.Data
{
    public partial class FalconContext : DbContext
    {
        public FalconContext()
        {
        }

        public FalconContext(DbContextOptions<FalconContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CheckPoints> CheckPoints { get; set; }
        public virtual DbSet<CheckpointsReference> CheckpointsReference { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<DevicesReference> DevicesReference { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<DocumentsReference> DocumentsReference { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Geofence> Geofence { get; set; }
        public virtual DbSet<GeofencesReference> GeofencesReference { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoicesReference> InvoicesReference { get; set; }
        public virtual DbSet<Issue> Issue { get; set; }
        public virtual DbSet<IssueTypesReference> IssueTypesReference { get; set; }
        public virtual DbSet<Local> Local { get; set; }
        public virtual DbSet<LocationsReference> LocationsReference { get; set; }
        public virtual DbSet<ManagementsReference> ManagementsReference { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<NotificationsReference> NotificationsReference { get; set; }
        public virtual DbSet<Options> Options { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PhoneNumbersReference> PhoneNumbersReference { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Swevents> Swevents { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TasksReference> TasksReference { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<TourEnd> TourEnd { get; set; }
        public virtual DbSet<TourStart> TourStart { get; set; }
        public virtual DbSet<ToursReference> ToursReference { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<White> White { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Falcon;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CheckPoints>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<CheckpointsReference>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<DevicesReference>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<DocumentsReference>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Geofence>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<GeofencesReference>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<InvoicesReference>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Issue>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<IssueTypesReference>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Local>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<LocationsReference>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<ManagementsReference>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<NotificationsReference>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Options>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<PhoneNumbersReference>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Alert).IsFixedLength();
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Swevents>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TasksReference>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TourEnd>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TourStart>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<ToursReference>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<White>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}