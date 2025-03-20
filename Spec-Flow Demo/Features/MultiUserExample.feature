Feature: Multiuser test example
  Scenario: Clicking commodities opens popover
    Given I have a user called User1
    Given I have a user called User2
    When User1 clicks commodities
    When User2 clicks commodities
    Then Commodities popover opens for User1
    Then Commodities popover opens for User2