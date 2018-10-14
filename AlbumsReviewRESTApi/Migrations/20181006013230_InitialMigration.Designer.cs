﻿// <auto-generated />
using System;
using AlbumsReviewRESTApi.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlbumsReviewRESTApi.Migrations
{
    [DbContext(typeof(AlbumsReviewContext))]
    [Migration("20181006013230_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlbumsReviewRESTApi.Entities.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ArtistId");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset>("Released");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Albums");

                    b.HasData(
                        new { Id = new Guid("bb5c8e98-548f-4766-b3fb-8c65a1b3a390"), ArtistId = new Guid("05638ad6-f6b9-40f3-be72-bd220295d059"), Name = "Honor Killed The Samurai", Released = new DateTimeOffset(new DateTime(2016, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) },
                        new { Id = new Guid("00d676d5-fdf8-4f26-816f-b3775c1b1e1a"), ArtistId = new Guid("2f3e0481-33fe-4283-b4b4-72e866acf5e8"), Name = "To Pimp a Butterfly", Released = new DateTimeOffset(new DateTime(2015, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) },
                        new { Id = new Guid("4ab21a9f-2041-4847-befb-57711b73f8d1"), ArtistId = new Guid("efc6df62-7c32-4916-8920-b510c3e11907"), Name = "Atrocity Exhibition", Released = new DateTimeOffset(new DateTime(2016, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) }
                    );
                });

            modelBuilder.Entity("AlbumsReviewRESTApi.Entities.Artist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("StageName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new { Id = new Guid("05638ad6-f6b9-40f3-be72-bd220295d059"), DateOfBirth = new DateTimeOffset(new DateTime(1972, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), FirstName = "Kaseem", LastName = "Ryan", StageName = "Ka" },
                        new { Id = new Guid("2f3e0481-33fe-4283-b4b4-72e866acf5e8"), DateOfBirth = new DateTimeOffset(new DateTime(1987, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), FirstName = "Kendrick", LastName = "Lamar Duckworth", StageName = "Kendrick Lamar" },
                        new { Id = new Guid("efc6df62-7c32-4916-8920-b510c3e11907"), DateOfBirth = new DateTimeOffset(new DateTime(1981, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), FirstName = "Daniel", LastName = "Dewan Sewell", StageName = "Danny Brown" }
                    );
                });

            modelBuilder.Entity("AlbumsReviewRESTApi.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AlbumId");

                    b.Property<float>("Rating");

                    b.Property<DateTimeOffset>("Submitted");

                    b.Property<string>("SubmittedReview")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new { Id = new Guid("bc62a8ea-2c2e-4ec2-a2a0-b4c48b523873"), AlbumId = new Guid("bb5c8e98-548f-4766-b3fb-8c65a1b3a390"), Rating = 5f, Submitted = new DateTimeOffset(new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), SubmittedReview = "A great Album" },
                        new { Id = new Guid("77534f47-9088-4207-97a1-e09d3d3b670a"), AlbumId = new Guid("bb5c8e98-548f-4766-b3fb-8c65a1b3a390"), Rating = 10f, Submitted = new DateTimeOffset(new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), SubmittedReview = "The best i have listened to" },
                        new { Id = new Guid("05de4a52-84ee-4bce-9921-9f1fc7912a69"), AlbumId = new Guid("00d676d5-fdf8-4f26-816f-b3775c1b1e1a"), Rating = 6f, Submitted = new DateTimeOffset(new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), SubmittedReview = "A Lovely piece" },
                        new { Id = new Guid("a1806419-0ba2-40b8-8528-919499a98be7"), AlbumId = new Guid("00d676d5-fdf8-4f26-816f-b3775c1b1e1a"), Rating = 4f, Submitted = new DateTimeOffset(new DateTime(2018, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), SubmittedReview = "LOVED IT!" },
                        new { Id = new Guid("ff6cd8e9-f886-4cc4-b9bf-0962609bfc47"), AlbumId = new Guid("4ab21a9f-2041-4847-befb-57711b73f8d1"), Rating = 9f, Submitted = new DateTimeOffset(new DateTime(2018, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), SubmittedReview = "DANNY BROWN SPAT FIRE" },
                        new { Id = new Guid("597bd736-afa1-40a3-b72a-38a1de525a2f"), AlbumId = new Guid("4ab21a9f-2041-4847-befb-57711b73f8d1"), Rating = 8f, Submitted = new DateTimeOffset(new DateTime(2018, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), SubmittedReview = "DANNY BROWN IS GOAT" }
                    );
                });

            modelBuilder.Entity("AlbumsReviewRESTApi.Entities.Album", b =>
                {
                    b.HasOne("AlbumsReviewRESTApi.Entities.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AlbumsReviewRESTApi.Entities.Review", b =>
                {
                    b.HasOne("AlbumsReviewRESTApi.Entities.Album", "Album")
                        .WithMany("Reviews")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
