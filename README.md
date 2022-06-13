# JurassicPark

PEDAC
My Dino Collection
P:roblem
create a class menagerie of deadly animals
Class should contain

- Name/Type
- Diet Carnivore/Herbivore
- WhenAcquired - default to current time when the dinosaur was created
- Weight
- EnclosureNumber

* Create a statement that will include all the fields listed above as a description of your monsters
  keep track of them via List<Dinosaur>

When console runs the user should be able to choose one of the following:

- view
  - command will ask the user if they wish to see BY name or enclosure number
  - Creatures should be displayed in the order selected (Alphabetical or Numerical?)
- Add
  - user can type information and add it to the list. Prompt for Name, DietType, Weight, and the EnclosureNumber. WhenAcquired must be supplied by a code.
- Remove
  - prompt user for name of dino, find and delete
- Transfer
  - Prompt for name & new EnclosureNumber, "Update".
- Summary
  - this command will display the number of Herbivores and Carnivores
- Quit
  Stop

E:xamples

- Douthinkisaurus
  - herb
  - 25 grams
- Diplodocus
  - Herb
  - 125 tons 113 tonnes
- Stinkisaurus
- herb/omni
- 25 ton
- farts
- Chicken
- carnivores
- 6 lbs
- Groot
  - Carbon
  - 10 grams - 6000 tons
- Diane
  - time and money
  - 170
- stegosaurus
  - herb
  - 7 tons
- Velociraptor
  - carnivore
  - 100 lbs
- Tyrannosaurus Rex
  - carnivore
  - 15000 lbs
- Triceratops
  - herb
  - 26000

D:ata

- List<Dinosaur>
- int - Weight/EnclosureNumber
- string - name/diet

A:lgorithm
List of Creatures with their attributes
string Name { get; set; }
string Diet { get; set; }
date WhenAcquired { get; }
int Weight { get; set; }
int EnclosureNumber { get; set; }

---

ToUpper responses to standardize answers from the user

to VIEW
Prompt: ¿ by NAME or by EnclosureNumber ?
answer = "Name":

- look up the Name
  answer = EnclosureNumber
- look up number

Prompt: ¿ View All ?

- return the list of every animal with all data attached

to Summarize

- Herb or Carn or All?
- per answer input
  - # herbivores
  - # carnivores
  - ## Dinosaurs

to ADD
Prompt: "WH name?"
Add to Name...
do the same for all categories

show new addition

to Remove:

Prompt: ¿ Name ?
Check to see if the Dino is listed
No: "No such creature in the pen"
Yes: List attributes " Are you sure? Y/N "
Y - delete
N - do nothing

show new listing

to Transfer

Prompt: ¿ Wh name ?
Check to see if the Dino is listed
No: "No such creature in the pen"
Yes: List attributes
Prompt: " ¿ Which Enclosure do you want to move it to ? "
Current Enclosure - ¿ Sure Y/N ?
New Enclosure

- No Enclosure with that number, create a new one Y/N?
- Y - create new EnclosureNumber
- N
- List EnclosureNumber - Select

to Quit
"Q"
