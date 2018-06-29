-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 05, 2018 at 09:14 PM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pharmashop`
--

-- --------------------------------------------------------

--
-- Table structure for table `branch`
--

CREATE TABLE `branch` (
  `branch_id` int(11) NOT NULL,
  `shopkeeper_id` int(11) NOT NULL,
  `branch_name` varchar(30) NOT NULL,
  `isinoperation` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `branch`
--

INSERT INTO `branch` (`branch_id`, `shopkeeper_id`, `branch_name`, `isinoperation`) VALUES
(1, 1, 'Centre', 1),
(2, 12, 'West', 1),
(3, 10, 'East', 1),
(4, 13, 'North', 1),
(5, 15, 'South', 1),
(8, 2, 'Outer', 1);

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `invoice_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `ordered_quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cart`
--

INSERT INTO `cart` (`invoice_id`, `product_id`, `ordered_quantity`) VALUES
(1, 1, 2),
(1, 6, 1),
(1, 9, 3),
(1, 12, 2),
(2, 2, 1),
(2, 4, 1),
(3, 13, 10),
(4, 5, 10),
(5, 6, 5),
(6, 19, 5),
(7, 41, 5),
(8, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `category_id` int(11) NOT NULL,
  `category_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`category_id`, `category_name`) VALUES
(1, 'Medicine'),
(2, 'Food'),
(3, 'Drink'),
(4, 'Others'),
(5, 'Meidcal Equipment');

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `client_id` int(11) NOT NULL,
  `client_type` varchar(50) NOT NULL,
  `restriction_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`client_id`, `client_type`, `restriction_id`) VALUES
(0, 'Kids', 0),
(1, 'Regular Customer', 1),
(2, 'Customer with Doctor Prescription', 2),
(3, 'Hospital Prescription', 3),
(5, 'Hospital', 4);

-- --------------------------------------------------------

--
-- Table structure for table `invoice`
--

CREATE TABLE `invoice` (
  `invoice_id` int(11) NOT NULL,
  `client_id` int(11) NOT NULL,
  `branch_id` int(11) DEFAULT NULL,
  `shopkeeper_id` int(11) NOT NULL,
  `pharmasist_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `invoice`
--

INSERT INTO `invoice` (`invoice_id`, `client_id`, `branch_id`, `shopkeeper_id`, `pharmasist_id`) VALUES
(1, 1, 1, 1, 1),
(2, 2, 1, 2, 2),
(3, 1, 1, 1, 1),
(4, 1, 1, 1, 1),
(5, 1, 1, 1, 2),
(6, 1, 2, 11, 5),
(7, 2, 4, 14, 7),
(8, 0, 1, 1, 1),
(10, 3, 4, 4, 3);

-- --------------------------------------------------------

--
-- Table structure for table `pharmasist`
--

CREATE TABLE `pharmasist` (
  `pharmasist_id` int(11) NOT NULL,
  `branch_id` int(11) DEFAULT NULL,
  `pharmasist_name` varchar(50) NOT NULL,
  `gender` varchar(6) NOT NULL DEFAULT 'Male',
  `isactive` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pharmasist`
--

INSERT INTO `pharmasist` (`pharmasist_id`, `branch_id`, `pharmasist_name`, `gender`, `isactive`) VALUES
(1, 1, 'Sam', 'Male', 1),
(2, 1, 'Adrian', 'Male', 1),
(3, 3, 'Eric', 'Male', 1),
(4, 3, 'Jean', 'Male', 1),
(5, 2, 'Mark', 'Male', 1),
(6, 2, 'Pierre', 'Male', 1),
(7, 4, 'Kenny', 'Female', 1),
(8, 5, 'Anna', 'Female', 1),
(9, 2, 'Nao', 'Male', 1);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `product_id` int(11) NOT NULL,
  `subcategory_id` int(11) DEFAULT NULL,
  `restriction_id` int(11) DEFAULT NULL,
  `branch_id` int(11) DEFAULT NULL,
  `product_name` varchar(50) NOT NULL,
  `product_description` varchar(200) NOT NULL,
  `product_price` int(11) DEFAULT NULL,
  `product_quantity` int(11) DEFAULT NULL,
  `isonmarket` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`product_id`, `subcategory_id`, `restriction_id`, `branch_id`, `product_name`, `product_description`, `product_price`, `product_quantity`, `isonmarket`) VALUES
(1, 16, 0, 1, 'Aqua 600ml', '', 5000, 331, 1),
(2, 10, 2, 1, 'Fukricin 5%', '', 40000, 20, 1),
(3, 8, 4, 1, 'Diamorphine 1kg', '', 400000, 0, 1),
(4, 10, 2, 1, 'Iliadin 0,05%', '', 61000, 4, 1),
(5, 9, 1, 1, 'Natra Bio', '', 8000, 40, 1),
(6, 9, 1, 1, 'Nelco OBH', '', 47000, 15, 1),
(7, 11, 2, 1, 'NonyX', '', 30000, 15, 1),
(8, 8, 3, 1, 'Morphine 1kg', '', 700000, 3, 1),
(9, 12, 1, 1, 'Xon-C', '', 6000, 22, 1),
(10, 14, 0, 1, 'Pocari Sweat 600ml', '', 10000, 20, 1),
(11, 13, 1, 1, 'Purple Corn 1kg', '', 70000, 10, 1),
(12, 15, 0, 1, 'Fitbar', '', 8000, 10, 1),
(13, 16, 0, 1, 'Oasis 600ml', '', 4000, 60, 1),
(14, 16, 0, 2, 'Aqua 600ml', '', 5000, 200, 1),
(15, 10, 2, 2, 'Fukricin 5%', '', 40000, 20, 1),
(16, 8, 4, 2, 'Diamorphine 1kg', '', 400000, 4, 1),
(17, 10, 2, 2, 'Iliadin 0,05%', '', 61000, 15, 1),
(18, 9, 1, 2, 'Natra Bio', '', 8000, 40, 1),
(19, 9, 1, 2, 'Nelco OBH', '', 47000, 10, 1),
(20, 11, 2, 2, 'NonyX', '', 30000, 15, 1),
(21, 8, 3, 2, 'Morphine 1kg', '', 700000, 2, 1),
(22, 12, 1, 2, 'Xon-C', '', 6000, 20, 1),
(23, 14, 0, 2, 'Pocari Sweat 600ml', '', 10000, 20, 1),
(24, 13, 1, 2, 'Purple Corn 1kg', '', 70000, 10, 1),
(25, 15, 0, 2, 'Fitbar', '', 8000, 10, 1),
(26, 16, 0, 2, 'Oasis 600ml', '', 4000, 50, 1),
(27, 16, 0, 3, 'Aqua 600ml', '', 5000, 200, 1),
(28, 10, 2, 3, 'Fukricin 5%', '', 40000, 20, 1),
(29, 8, 4, 3, 'Diamorphine 1kg', '', 400000, 4, 1),
(30, 10, 2, 3, 'Iliadin 0,05%', '', 61000, 15, 1),
(31, 9, 1, 3, 'Natra Bio', '', 8000, 40, 1),
(32, 9, 1, 3, 'Nelco OBH', '', 47000, 15, 1),
(33, 11, 2, 3, 'NonyX', '', 30000, 15, 1),
(34, 8, 3, 3, 'Morphine 1kg', '', 700000, 2, 1),
(35, 12, 1, 3, 'Xon-C', '', 6000, 20, 1),
(36, 14, 0, 3, 'Pocari Sweat 600ml', '', 10000, 20, 1),
(37, 13, 1, 3, 'Purple Corn 1kg', '', 70000, 10, 1),
(38, 15, 0, 3, 'Fitbar', '', 8000, 10, 1),
(39, 16, 0, 3, 'Oasis 600ml', '', 4000, 50, 1),
(40, 16, 0, 4, 'Aqua 600ml', '', 5000, 200, 1),
(41, 10, 2, 4, 'Fukricin 5%', '', 40000, 15, 1),
(42, 8, 4, 4, 'Diamorphine 1kg', '', 400000, 4, 1),
(43, 10, 2, 4, 'Iliadin 0,05%', '', 61000, 15, 1),
(44, 9, 1, 4, 'Natra Bio', '', 8000, 40, 1),
(45, 9, 1, 4, 'Nelco OBH', '', 47000, 15, 1),
(46, 11, 2, 4, 'NonyX', '', 30000, 15, 1),
(47, 8, 3, 4, 'Morphine 1kg', '', 700000, 2, 1),
(48, 12, 1, 4, 'Xon-C', '', 6000, 20, 1),
(49, 14, 0, 4, 'Pocari Sweat 600ml', '', 10000, 20, 1),
(50, 13, 1, 4, 'Purple Corn 1kg', '', 70000, 10, 1),
(51, 15, 0, 4, 'Fitbar', '', 8000, 10, 1),
(52, 16, 0, 4, 'Oasis 600ml', '', 4000, 50, 1),
(53, 16, 0, 5, 'Aqua 600ml', '', 5000, 200, 1),
(54, 10, 2, 5, 'Fukricin 5%', '', 40000, 20, 1),
(55, 8, 4, 5, 'Diamorphine 1kg', '', 400000, 4, 1),
(56, 10, 2, 5, 'Iliadin 0,05%', '', 61000, 15, 1),
(57, 9, 1, 5, 'Natra Bio', '', 8000, 40, 1),
(58, 9, 1, 5, 'Nelco OBH', '', 47000, 15, 1),
(59, 11, 2, 5, 'NonyX', '', 30000, 15, 1),
(60, 8, 3, 5, 'Morphine 1kg', '', 700000, 2, 1),
(61, 12, 1, 5, 'Xon-C', '', 6000, 20, 1),
(62, 14, 0, 5, 'Pocari Sweat 600ml', '', 10000, 20, 1),
(63, 13, 1, 5, 'Purple Corn 1kg', '', 70000, 10, 1),
(64, 15, 0, 5, 'Fitbar', '', 8000, 10, 1),
(65, 16, 0, 5, 'Oasis 600ml', '', 4000, 50, 1),
(70, 8, 0, 1, 'Amoxalin', '', 10000, 100, 1),
(71, 9, 3, 4, 'Mega-cine', '', 200000, 0, 1),
(72, 13, 1, 1, 'Migorana Mie', '', 2000, 0, 1),
(73, 12, 0, 4, 'Vitacimin', '', 7000, 0, 1);

-- --------------------------------------------------------

--
-- Table structure for table `restriction`
--

CREATE TABLE `restriction` (
  `restriction_id` int(11) NOT NULL,
  `restriction_level` int(11) DEFAULT NULL,
  `description` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `restriction`
--

INSERT INTO `restriction` (`restriction_id`, `restriction_level`, `description`) VALUES
(0, 0, 'General'),
(1, 1, 'Over-the-counter'),
(2, 2, 'Doctor Prescription (Regular)'),
(3, 3, 'Hospital Use / Special Prescription (Critical)'),
(4, 4, 'Hospital use Only');

-- --------------------------------------------------------

--
-- Table structure for table `shopkeeper`
--

CREATE TABLE `shopkeeper` (
  `shopkeeper_id` int(11) NOT NULL,
  `branch_id` int(11) DEFAULT NULL,
  `shopkeeper_name` varchar(50) NOT NULL,
  `Gender` varchar(6) NOT NULL DEFAULT 'Male',
  `age` int(11) NOT NULL DEFAULT '21',
  `phone` varchar(20) NOT NULL,
  `hashed_password` varchar(50) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `admin_permission` tinyint(1) NOT NULL DEFAULT '0',
  `comment` varchar(50) NOT NULL,
  `isactive` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shopkeeper`
--

INSERT INTO `shopkeeper` (`shopkeeper_id`, `branch_id`, `shopkeeper_name`, `Gender`, `age`, `phone`, `hashed_password`, `admin_permission`, `comment`, `isactive`) VALUES
(0, 1, 'Owner', 'Male', 21, '', '*B37DE9C6D0F92025B94F935C9914C8A2F10A9DC1', 1, 'pass=owner (do not delete)', 1),
(1, 1, 'Martin', 'Male', 21, '', '*433BE2849BD4D2C882F54E2CFA34E2821CEFB030', 1, 'pass=Martin', 0),
(2, 1, 'Tony', 'Male', 21, '', '*B10DCF9BD984B509EAC48AC68B4C2E1EDE585850', 0, 'pass=Tony', 1),
(3, 2, 'Jack', 'Male', 21, '', '*B9DF54B251F330BF8F5D0ADBFE7D2C2A02C37788', 0, 'pass=Jack', 1),
(4, 2, 'Mack', 'Male', 21, '', '*4CDDFD0B7925FE5DC11AD00917F93CF99D104299', 0, 'pass=Mack', 1),
(5, 3, 'Brian', 'Male', 21, '', '*2CC029A4DB70A1632CDF31E1E091AA186B3B3F9F', 0, 'pass=Brian', 1),
(6, 3, 'Russell', 'Male', 21, '', '*B76184C5165BE51BA5EC38F9724B9E0C39C7139C', 0, 'pass=Russell', 1),
(7, 1, 'Sam', 'Male', 21, '', '*D8DD27F0CE7DD27AE18BCBC10D736C9F98B49D8B', 1, 'pass=Sam', 1),
(8, 1, 'Adrian', 'Male', 21, '', '*D92DEFB4F3960FA3543F1EA849FBADEAF2556A53', 0, 'pass=Adrian', 1),
(9, 1, 'Eric', 'Male', 21, '', '*676394057F711F90F73B5F6D84AB32E9DEFC7F70', 0, 'pass=Eric', 1),
(10, 3, 'Jean', 'Male', 21, '', '*D708B6CF0374768766BB7B926FA2CD7A85187777', 1, 'pass=Jean', 1),
(11, 2, 'Mark', 'Male', 21, '', '*0BEEB0F1E0E4B541A11E5124F3E7F6D55626DF20', 0, 'pass=Mark', 1),
(12, 2, 'Pierre', 'Male', 21, '', '*EB346C6F51FE215CD0433734A37249192A62EF63', 1, 'pass=Pierre', 1),
(13, 4, 'Kenny', 'Female', 21, '', '*447B16796B382C14AEE09AE42B1BB12B43DA6154', 1, 'pass=Kenny', 1),
(14, 4, 'Jeanne', 'Female', 21, '', '*2FBD927CAA238979458C8E4BC290A54C7EE6086C', 0, 'pass=Jeanne', 1),
(15, 5, 'Anna', 'Female', 21, '', '*C003D7D310D77510D685D31A640295CA611E95B7', 1, 'pass=Anna', 1);

-- --------------------------------------------------------

--
-- Table structure for table `subcategory`
--

CREATE TABLE `subcategory` (
  `subcategory_id` int(11) NOT NULL,
  `subcategory_name` varchar(50) NOT NULL,
  `category_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subcategory`
--

INSERT INTO `subcategory` (`subcategory_id`, `subcategory_name`, `category_id`) VALUES
(8, 'Drugs', 1),
(9, 'Medicinal Syrup', 1),
(10, 'Medicinal Drops', 1),
(11, 'Medicinal Paste', 1),
(12, 'Supplement', 1),
(13, 'Grocery', 2),
(14, 'Electrolyte Drinks', 3),
(15, 'Snacks', 2),
(16, 'Mineral Water', 3);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `branch`
--
ALTER TABLE `branch`
  ADD PRIMARY KEY (`branch_id`),
  ADD KEY `shopkeeper_id` (`shopkeeper_id`);

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD KEY `invoice_constraint` (`invoice_id`) USING BTREE,
  ADD KEY `cart_ibfk_2` (`product_id`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`category_id`);

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`client_id`),
  ADD KEY `client_ibfk_1` (`restriction_id`);

--
-- Indexes for table `invoice`
--
ALTER TABLE `invoice`
  ADD PRIMARY KEY (`invoice_id`),
  ADD KEY `invoice_ibfk_1` (`client_id`),
  ADD KEY `invoice_ibfk_2` (`pharmasist_id`),
  ADD KEY `invoice_ibfk_3` (`shopkeeper_id`),
  ADD KEY `invoice_branch` (`invoice_id`),
  ADD KEY `invoice_index` (`branch_id`);

--
-- Indexes for table `pharmasist`
--
ALTER TABLE `pharmasist`
  ADD PRIMARY KEY (`pharmasist_id`),
  ADD KEY `pharmasist_branch` (`branch_id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`product_id`),
  ADD KEY `product_ibfk_2` (`restriction_id`),
  ADD KEY `product_ibfk_1` (`subcategory_id`),
  ADD KEY `product_ibfk_3` (`branch_id`);

--
-- Indexes for table `restriction`
--
ALTER TABLE `restriction`
  ADD PRIMARY KEY (`restriction_id`);

--
-- Indexes for table `shopkeeper`
--
ALTER TABLE `shopkeeper`
  ADD PRIMARY KEY (`shopkeeper_id`),
  ADD KEY `shopkeep_branch` (`branch_id`);

--
-- Indexes for table `subcategory`
--
ALTER TABLE `subcategory`
  ADD PRIMARY KEY (`subcategory_id`),
  ADD KEY `category_id` (`category_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `branch`
--
ALTER TABLE `branch`
  MODIFY `branch_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `category_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `client`
--
ALTER TABLE `client`
  MODIFY `client_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `invoice`
--
ALTER TABLE `invoice`
  MODIFY `invoice_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `pharmasist`
--
ALTER TABLE `pharmasist`
  MODIFY `pharmasist_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=74;

--
-- AUTO_INCREMENT for table `restriction`
--
ALTER TABLE `restriction`
  MODIFY `restriction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `shopkeeper`
--
ALTER TABLE `shopkeeper`
  MODIFY `shopkeeper_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `subcategory`
--
ALTER TABLE `subcategory`
  MODIFY `subcategory_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `branch`
--
ALTER TABLE `branch`
  ADD CONSTRAINT `shopkeeper_id` FOREIGN KEY (`shopkeeper_id`) REFERENCES `shopkeeper` (`shopkeeper_id`);

--
-- Constraints for table `cart`
--
ALTER TABLE `cart`
  ADD CONSTRAINT `cart_ibfk_1` FOREIGN KEY (`invoice_id`) REFERENCES `invoice` (`invoice_id`),
  ADD CONSTRAINT `cart_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `product` (`product_id`);

--
-- Constraints for table `client`
--
ALTER TABLE `client`
  ADD CONSTRAINT `client_ibfk_1` FOREIGN KEY (`restriction_id`) REFERENCES `restriction` (`restriction_id`);

--
-- Constraints for table `invoice`
--
ALTER TABLE `invoice`
  ADD CONSTRAINT `invoice_ibfk_1` FOREIGN KEY (`client_id`) REFERENCES `client` (`client_id`),
  ADD CONSTRAINT `invoice_ibfk_2` FOREIGN KEY (`pharmasist_id`) REFERENCES `pharmasist` (`pharmasist_id`),
  ADD CONSTRAINT `invoice_ibfk_3` FOREIGN KEY (`shopkeeper_id`) REFERENCES `shopkeeper` (`shopkeeper_id`),
  ADD CONSTRAINT `invoice_index` FOREIGN KEY (`branch_id`) REFERENCES `branch` (`branch_id`);

--
-- Constraints for table `pharmasist`
--
ALTER TABLE `pharmasist`
  ADD CONSTRAINT `pharmasist_branch` FOREIGN KEY (`branch_id`) REFERENCES `branch` (`branch_id`);

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`subcategory_id`) REFERENCES `subcategory` (`subcategory_id`),
  ADD CONSTRAINT `product_ibfk_2` FOREIGN KEY (`restriction_id`) REFERENCES `restriction` (`restriction_id`),
  ADD CONSTRAINT `product_ibfk_3` FOREIGN KEY (`branch_id`) REFERENCES `branch` (`branch_id`);

--
-- Constraints for table `shopkeeper`
--
ALTER TABLE `shopkeeper`
  ADD CONSTRAINT `shopkeep_branch` FOREIGN KEY (`branch_id`) REFERENCES `branch` (`branch_id`);

--
-- Constraints for table `subcategory`
--
ALTER TABLE `subcategory`
  ADD CONSTRAINT `subcategory_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `category` (`category_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
