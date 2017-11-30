# Service for managing the tables.

## Input Data Sample

```csv
Table-1;Dani Durant;Carrot;Meat;Chocolate
Table-1;Jean Durant;Carrot;Fish;Chocolate
Table-1;Eric Egan;Carrot;Meat;Chocolate
Table-2;Jean-Elie Dupond;Carrot;Fish;Chocolate
```

### Output Data Sample : 


```
Starter : 
	Table-1:
		Dani Durant: Carrot
		Jean Durant: Carrot
		Eric Egan: Carrot
	
	Table-2:
		Jean-Elie: Carrot


Main course : 
	Table-1:
		Dani Durant: Meat
		Jean Durant: Fish
		Eric Egan: Mear
	
	Table-2:
		Jean-Elie: Fish

Dessert : 

	Table-1:
		Dani Durant: Chocolate
		Jean Durant: Chocolate
		Eric Egan: Chocolate
	
	Table-2:
		Jean-Elie Dupond: Chocolate

```

#### Limit

1. If the table contains less or more than 10 participants (Who contact)?
2. If the participant is present more than once (What we need to do ) ?
3. If the Starter or the Dessert are not good ? 

Sample : 

If one participant contain nothing.

```csv
Table-1;Dani Durant;NOTHING;Meat;Chocolate
Table-1;Jean Durant;Carrot;Fish;Chocolate
```

4. If one participant not contain in the main course Meat or Fish (May be Contact the participant)?
