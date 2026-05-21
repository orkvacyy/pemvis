-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 21, 2026 at 06:05 PM
-- Server version: 8.0.30
-- PHP Version: 8.4.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hevy_pemvis`
--

-- --------------------------------------------------------

--
-- Table structure for table `exercises`
--

CREATE TABLE `exercises` (
  `id` int NOT NULL,
  `name` varchar(100) NOT NULL,
  `muscle_group` varchar(50) NOT NULL,
  `equipment` varchar(50) NOT NULL,
  `user_id` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `exercises`
--

INSERT INTO `exercises` (`id`, `name`, `muscle_group`, `equipment`, `user_id`) VALUES
(48, 'Treadmill Run', 'Cardio', 'Machine', NULL),
(49, 'Outdoor Running', 'Cardio', 'None', NULL),
(50, 'Cycling (Stationary)', 'Cardio', 'Machine', NULL),
(51, 'Jump Rope', 'Cardio', 'Bodyweight', NULL),
(52, 'Rowing Machine', 'Cardio', 'Machine', NULL),
(53, 'Stair Climber', 'Cardio', 'Machine', NULL),
(54, 'Elliptical Trainer', 'Cardio', 'Machine', NULL),
(55, 'Swimming', 'Cardio', 'None', NULL),
(56, 'Barbell Bench Press', 'Chest', 'Barbell', NULL),
(57, 'Incline Dumbbell Press', 'Chest', 'Dumbbell', NULL),
(58, 'Push Up', 'Chest', 'Bodyweight', NULL),
(59, 'Cable Crossover', 'Chest', 'Cable', NULL),
(60, 'Pull Up', 'Back', 'Bodyweight', NULL),
(61, 'Lat Pulldown', 'Back', 'Cable', NULL),
(62, 'Barbell Row', 'Back', 'Barbell', NULL),
(63, 'Deadlift', 'Back', 'Barbell', NULL),
(64, 'Barbell Squat', 'Legs', 'Barbell', NULL),
(65, 'Leg Press', 'Legs', 'Machine', NULL),
(66, 'Romanian Deadlift', 'Legs', 'Barbell', NULL),
(67, 'Calf Raise', 'Legs', 'Bodyweight', NULL),
(68, 'Lunges', 'Legs', 'Dumbbell', NULL),
(69, 'Dumbbell Bicep Curl', 'Arms', 'Dumbbell', NULL),
(70, 'Hammer Curl', 'Arms', 'Dumbbell', NULL),
(71, 'Tricep Pushdown', 'Arms', 'Cable', NULL),
(72, 'Overhead Tricep Extension', 'Arms', 'Dumbbell', NULL),
(73, 'Overhead Press', 'Shoulders', 'Barbell', NULL),
(74, 'Lateral Raise', 'Shoulders', 'Dumbbell', NULL),
(75, 'Front Raise', 'Shoulders', 'Dumbbell', NULL),
(76, 'Plank', 'Core', 'Bodyweight', NULL),
(77, 'Crunch', 'Core', 'Bodyweight', NULL),
(78, 'Russian Twist', 'Core', 'Dumbbell', NULL),
(79, 'Leg Raise', 'Core', 'Bodyweight', NULL),
(80, 'Burpees', 'Full Body', 'Bodyweight', NULL),
(81, 'Kettlebell Swing', 'Full Body', 'Kettlebell', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` enum('admin','user') NOT NULL DEFAULT 'user',
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `role`, `created_at`) VALUES
(1, 'admin', '1234', 'admin', '2026-05-20 21:22:37'),
(2, 'user', '2321321', 'user', '2026-05-20 21:57:12'),
(3, 'aku', 'fanny123', 'user', '2026-05-20 22:21:36'),
(5, 'sifwah', 'fanny123', 'user', '2026-05-21 23:29:04');

-- --------------------------------------------------------

--
-- Table structure for table `workouts`
--

CREATE TABLE `workouts` (
  `id` int NOT NULL,
  `name` varchar(100) NOT NULL DEFAULT 'New Workout',
  `date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `notes` text,
  `user_id` int DEFAULT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'ongoing'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `workouts`
--

INSERT INTO `workouts` (`id`, `name`, `date`, `notes`, `user_id`, `status`) VALUES
(12, 'New Workout', '2026-05-20 15:10:28', '', NULL, 'ongoing'),
(13, 'New Workout', '2026-05-20 15:11:05', '', NULL, 'ongoing'),
(14, 'New Workout', '2026-05-20 21:40:52', '', NULL, 'ongoing'),
(19, 'New Workout', '2026-05-21 23:35:55', '', 5, 'ongoing'),
(30, 'New Workout', '2026-05-22 01:02:39', '', 5, 'ongoing');

-- --------------------------------------------------------

--
-- Table structure for table `workout_exercises`
--

CREATE TABLE `workout_exercises` (
  `id` int NOT NULL,
  `workout_id` int NOT NULL,
  `exercise_id` int NOT NULL,
  `order_index` int NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `workout_sets`
--

CREATE TABLE `workout_sets` (
  `id` int NOT NULL,
  `workout_exercise_id` int NOT NULL,
  `set_number` int NOT NULL DEFAULT '1',
  `weight` decimal(7,2) NOT NULL DEFAULT '0.00',
  `reps` int NOT NULL DEFAULT '0',
  `completed` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `exercises`
--
ALTER TABLE `exercises`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_ex_user` (`user_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `workouts`
--
ALTER TABLE `workouts`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_w_user` (`user_id`);

--
-- Indexes for table `workout_exercises`
--
ALTER TABLE `workout_exercises`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_we_workout` (`workout_id`),
  ADD KEY `fk_we_exercise` (`exercise_id`);

--
-- Indexes for table `workout_sets`
--
ALTER TABLE `workout_sets`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_ws_we` (`workout_exercise_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `exercises`
--
ALTER TABLE `exercises`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=82;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `workouts`
--
ALTER TABLE `workouts`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- AUTO_INCREMENT for table `workout_exercises`
--
ALTER TABLE `workout_exercises`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `workout_sets`
--
ALTER TABLE `workout_sets`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `exercises`
--
ALTER TABLE `exercises`
  ADD CONSTRAINT `fk_ex_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `workouts`
--
ALTER TABLE `workouts`
  ADD CONSTRAINT `fk_w_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `workout_exercises`
--
ALTER TABLE `workout_exercises`
  ADD CONSTRAINT `fk_we_exercise` FOREIGN KEY (`exercise_id`) REFERENCES `exercises` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_we_workout` FOREIGN KEY (`workout_id`) REFERENCES `workouts` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `workout_sets`
--
ALTER TABLE `workout_sets`
  ADD CONSTRAINT `fk_ws_we` FOREIGN KEY (`workout_exercise_id`) REFERENCES `workout_exercises` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
