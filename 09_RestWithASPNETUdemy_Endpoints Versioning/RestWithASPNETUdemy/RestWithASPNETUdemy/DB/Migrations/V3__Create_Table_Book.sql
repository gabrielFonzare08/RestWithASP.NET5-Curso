CREATE TABLE IF NOT EXISTS `book` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `title` varchar(150) NOT NULL,
  `author` varchar(100) NOT NULL,
  `gender` varchar(45) NOT NULL,
  `assessment` decimal(10,2) NOT NULL,
  `year` integer NOT NULL,
  `edition` integer NOT NULL,
  PRIMARY KEY (`id`)
) 