// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolCodeFirstDB.DataModels;

#nullable disable

namespace SchoolCodeFirstDB.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230226210301_MaxLengthApplied")]
    partial class MaxLengthApplied
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolCodeFirstDB.DataModels.Class", b =>
                {
                    b.Property<int>("ClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassID"));

                    b.Property<int>("ClassLanguage")
                        .HasColumnType("int");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MaxClassSize")
                        .HasColumnType("int");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ClassID");

                    b.HasIndex("StudentID");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("SchoolCodeFirstDB.DataModels.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolCodeFirstDB.DataModels.Class", b =>
                {
                    b.HasOne("SchoolCodeFirstDB.DataModels.Student", null)
                        .WithMany("studentClasses")
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("SchoolCodeFirstDB.DataModels.Student", b =>
                {
                    b.Navigation("studentClasses");
                });
#pragma warning restore 612, 618
        }
    }
}
