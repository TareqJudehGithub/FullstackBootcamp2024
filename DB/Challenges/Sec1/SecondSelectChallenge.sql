-- SELECT 2nd challenge
USE SAMPLEDB;

-- Return unique data under locality column from bird.antarctic_populations table
SELECT 
   DISTINCT locality
FROM bird.antarctic_populations
GO

-- Return unique data under locality and species_id column under bird.antarctic_populations
SELECT
    DISTINCT 
        locality, 
        species_id
FROM bird.antarctic_populations

