-- CREATE DATABASE blog;

CREATE SCHEMA "Blog";

CREATE TABLE IF NOT EXISTS "Blog"."Article" (
    "Id" VARCHAR(32) PRIMARY KEY,
    "Title" VARCHAR(128) NOT NULL,
    "Content" TEXT NOT NULL,
    "AuthorId" VARCHAR(32) DEFAULT '' NOT NULL,
    "CategoryId" VARCHAR(32) NOT NULL,
    "Archived" BOOLEAN DEFAULT FALSE,
    "Published" BOOLEAN DEFAULT FALSE,
    "CreateTime" TIMESTAMP DEFAULT now(),
    "UpdateTime" TIMESTAMP DEFAULT now()
);

CREATE TABLE IF NOT EXISTS "Blog"."ArticleHistory" (
    "Id" VARCHAR(32) PRIMARY KEY,
    "ArticleId" VARCHAR(32),
    "Content" TEXT NOT NULL,
    "CreateTime" TIMESTAMP DEFAULT now()
);

CREATE TABLE IF NOT EXISTS "Blog"."Category" (
    "Id" VARCHAR(32) PRIMARY KEY,
    "Name" VARCHAR(64) NOT NULL,
    "Level" INTEGER DEFAULT 1,
    "ParentId" VARCHAR(32),
    "CreateTime" TIMESTAMP DEFAULT now(),
    "UpdateTime" TIMESTAMP DEFAULT now()
);

CREATE TABLE IF NOT EXISTS "Blog"."Tag" (
    "Id" VARCHAR(32) PRIMARY KEY,
    "Name" VARCHAR(64) NOT NULL,
    "CreateTime" TIMESTAMP DEFAULT now(),
    "UpdateTIme" TIMESTAMP DEFAULT now(),
);

CREATE TABLE IF NOT EXISTS "Blog"."ArticleTag" (
    "ArticleId" VARCHAR(32),
    "TagId" VARCHAR(32),
    "CreateTime" TIMESTAMP DEFAULT now(),
    "UpdateTIme" TIMESTAMP DEFAULT now(),
    CONSTRAINT article_tag UNIQUE("ArticleId", "TagId")
);