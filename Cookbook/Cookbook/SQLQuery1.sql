﻿SELECT * FROM Recipe

select * from Ingredient

SELECT a.Name FROM Ingredient a
INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId
WHERE b.RecipeId = 1;