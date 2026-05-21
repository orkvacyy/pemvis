-- SQL Setup untuk Database hevy_pemvis (Updated Version)
CREATE DATABASE IF NOT EXISTS `hevy_pemvis`;
USE `hevy_pemvis`;

SET FOREIGN_KEY_CHECKS = 0;
DROP TABLE IF EXISTS `workout_sets`;
DROP TABLE IF EXISTS `workout_exercises`;
DROP TABLE IF EXISTS `workouts`;
DROP TABLE IF EXISTS `exercises`;
DROP TABLE IF EXISTS `users`;
SET FOREIGN_KEY_CHECKS = 1;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` enum('admin','user') NOT NULL DEFAULT 'user',
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `users`
--
INSERT INTO `users` (`id`, `username`, `password`, `role`, `created_at`) VALUES
(1, 'admin', '1234', 'admin', '2026-05-20 21:22:37'),
(2, 'user', '2321321', 'user', '2026-05-20 21:57:12'),
(3, 'aku', 'fanny123', 'user', '2026-05-20 22:21:36');

-- --------------------------------------------------------

--
-- Table structure for table `exercises`
--
CREATE TABLE `exercises` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `muscle_group` varchar(50) NOT NULL,
  `equipment` varchar(50) NOT NULL,
  `user_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_ex_user` (`user_id`),
  CONSTRAINT `fk_ex_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `exercises`
--
INSERT INTO `exercises` (`id`, `name`, `muscle_group`, `equipment`, `user_id`) VALUES
(1, 'dumbbel bench press', 'Chest', 'Dumbbell', NULL),
(2, 'tasda', 'Chest', 'None', NULL),
(4, 'tes2', 'Shoulders', 'Machine', NULL),
(9, 'kocakkkkk', 'Chest', 'Cables', NULL),
(10, 'Running', 'Cardio', 'None', NULL),
(11, 'Cycling', 'Cardio', 'Bicycle', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `workouts`
--
CREATE TABLE `workouts` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT 'New Workout',
  `date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `notes` text,
  `user_id` int DEFAULT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'ongoing',
  PRIMARY KEY (`id`),
  KEY `fk_w_user` (`user_id`),
  CONSTRAINT `fk_w_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `workouts`
--
INSERT INTO `workouts` (`id`, `name`, `date`, `notes`, `user_id`, `status`) VALUES
(12, 'New Workout', '2026-05-20 15:10:28', '', NULL, 'ongoing'),
(13, 'New Workout', '2026-05-20 15:11:05', '', NULL, 'ongoing'),
(14, 'New Workout', '2026-05-20 21:40:52', '', NULL, 'ongoing'),
(16, 'New Workout', '2026-05-21 14:18:19', '', 1, 'ongoing');

-- --------------------------------------------------------

--
-- Table structure for table `workout_exercises`
--
CREATE TABLE `workout_exercises` (
  `id` int NOT NULL AUTO_INCREMENT,
  `workout_id` int NOT NULL,
  `exercise_id` int NOT NULL,
  `order_index` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `fk_we_workout` (`workout_id`),
  KEY `fk_we_exercise` (`exercise_id`),
  CONSTRAINT `fk_we_exercise` FOREIGN KEY (`exercise_id`) REFERENCES `exercises` (`id`) ON DELETE CASCADE,
  CONSTRAINT `fk_we_workout` FOREIGN KEY (`workout_id`) REFERENCES `workouts` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `workout_sets`
--
CREATE TABLE `workout_sets` (
  `id` int NOT NULL AUTO_INCREMENT,
  `workout_exercise_id` int NOT NULL,
  `set_number` int NOT NULL DEFAULT '1',
  `weight` decimal(7,2) NOT NULL DEFAULT '0.00',
  `reps` int NOT NULL DEFAULT '0',
  `completed` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `fk_ws_we` (`workout_exercise_id`),
  CONSTRAINT `fk_ws_we` FOREIGN KEY (`workout_exercise_id`) REFERENCES `workout_exercises` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
