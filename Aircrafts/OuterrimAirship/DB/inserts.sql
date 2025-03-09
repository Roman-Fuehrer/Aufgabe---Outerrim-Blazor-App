INSERT INTO SpacecraftSpecifications (Id, Structure, FuelTankCapacity, MinSpeed, MaxSpeed, MaxAltitude, SpecificationCode) VALUES (1, 3, 10, 2, 6, 5, 'Tunderbolt');
INSERT INTO SpacecraftSpecifications (Id, Structure, FuelTankCapacity, MinSpeed, MaxSpeed, MaxAltitude, SpecificationCode) VALUES (2, 2, 8, 3, 8, 4, 'Vulture');

INSERT INTO Spacecrafts (Id, Altitude, Fuel, Name, SpacecraftSpecificationId, Speed) VALUES (1, 5, 6, 'Executioner', 1, 4);
INSERT INTO Spacecrafts (Id, Altitude, Fuel, Name, SpacecraftSpecificationId, Speed) VALUES (2, 3, 3, 'Dakkajet', 2, 3);

INSERT INTO MERCENARIES (Id, BodySkills, CombatSkills, FirstName, LastName) VALUES (1, 4, 4, 'Han', 'Solo');
INSERT INTO MERCENARIES (Id, BodySkills, CombatSkills, FirstName, LastName) VALUES (2, 8, 8, 'Luke', 'Skywalker');

INSERT INTO COMPARTMENTS (CompartmentId, SpacecraftId) VALUES (1, 1);
INSERT INTO COMPARTMENTS (CompartmentId, SpacecraftId) VALUES (2, 1);
INSERT INTO COMPARTMENTS (CompartmentId, SpacecraftId) VALUES (3, 1);
INSERT INTO COMPARTMENTS (CompartmentId, SpacecraftId) VALUES (4, 1);


INSERT INTO SpacecraftSpecifications (Id, STRUCTURE, FuelTankCapacity, MinSpeed, MaxSpeed, MaxAltitude, SpecificationCode)
VALUES
    (3, 5, 12, 4, 9, 6, 'Raptor'),
    (4, 6, 15, 5, 12, 7, 'Blackhawk');

INSERT INTO Spacecrafts (Id, Altitude, Fuel,  Name, SpacecraftSpecificationId, Speed)
VALUES
    (3, 6, 8, 'Raptor-X', 3, 5),
    (4, 7, 10, 'Nightmare', 4, 7);

INSERT INTO Mercenaries (Id, BodySkills, CombatSkills, FirstName, LastName)
VALUES
    (3, 6, 5, 'Boba', 'Fett'),
    (4, 7, 7, 'Jango', 'Fett');

INSERT INTO COMPARTMENTS (CompartmentId, SpacecraftId)
VALUES
    (5, 2),
    (6, 2),
    (7, 3),
    (8, 3),
    (9, 4),
    (10, 4);

INSERT INTO Machineries (MachineryId, CompartmentId, Label, Function, Type)
VALUES
    (1, 1, 'Flight Control Panel', 'Controls aircraft movement', 'EnvironmentalSystem'),
    (2, 3, 'Main Engine', 'Provides thrust for flight', 'EnergySystem'),
    (3, 4, 'Missile Launcher', 'Launches guided missiles', 'Weapon'),
    (4, 6, 'Cargo Loader', 'Automates cargo management', 'EnvironmentalSystem'),
    (5, 8, 'Laser Defense System', 'Protects against incoming threats', 'Weapon'),
    (6, 10, 'Fusion Reactor', 'Generates energy for ship systems', 'EnergySystem');

INSERT INTO CrimeSyndicates (Id, Name, Location)
VALUES
    (1, 'Black Sun Cartel', 'Nar Shaddaa'),
    (2, 'The Crimson Dawn', 'Corellia'),
    (3, 'Shadow Syndicate', 'Coruscant Underworld');

INSERT INTO MercenaryReputations (MercenaryId, CrimeSyndicateId, ReputationChange)
VALUES
    (1, 1, 20), -- Han Solo ist mit dem Black Sun Cartel verbunden
    (2, 2, 10), -- Luke Skywalker hat eine Verbindung zur Crimson Dawn
    (3, 3, 12), -- Boba Fett arbeitet mit dem Shadow Syndicate zusammen
    (4, 1, 12); -- Jango Fett hat ebenfalls eine Verbindung zum Black Sun Cartel


INSERT INTO Crews (SpacecraftId, MercenaryId, JoinedAt)
VALUES
    (1, 1, '2310-06-29'), -- Han Solo ist Crew auf "Executioner"
    (2, 2, '2314-07-29'), -- Luke Skywalker ist Crew auf "Dakkajet"
    (3, 3, '2310-12-05'), -- Boba Fett ist Crew auf "Raptor-X"
    (4, 4, '2322-06-16'); -- Jango Fett ist Crew auf "Nightmare"