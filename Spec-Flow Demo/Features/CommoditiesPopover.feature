﻿Feature: Commodities popover
  Scenario: Clicking commodities opens popover
    Given I have a user called User1
    When User1 clicks commodities
    Then Commodities popover opens for User1

