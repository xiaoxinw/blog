-- CREATE DATABASE blog;

CREATE SCHEMA "Blog";

CREATE TABLE IF NOT EXISTS "Blog"."Article" (
    "Id" VARCHAR(32) PRIMARY KEY,
    "Title" VARCHAR(128) NOT NULL,
    "Content" TEXT NOT NULL,
    "CreateTime" TIMESTAMP DEFAULT now(),
    "UpdateTime" TIMESTAMP DEFAULT now(),
    "AuthorId" VARCHAR(32) DEFAULT '' NOT NULL
);