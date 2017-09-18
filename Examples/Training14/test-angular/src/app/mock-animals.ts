import { Animal } from './animal';
 
export const ANIMALS: Animal[] = [
  { 
      id: 1, 
      name: 'Rabbit', 
      summary: `<p>
                Some text here.  Rabbits are the third most popular pet in America, after cats and dogs, according to the Humane Society of the United States—and the third most abandoned. Most Americans have a sense of how long cats and dogs live, the kind of care they need, their behaviors. But rabbits? I asked several of my colleagues how long they think domestic rabbits live. “One to two years?” “Maybe three?” In fact, with proper care, rabbits live 10 to 12 years. People's understanding of them seems to be out of step with their ubiquity.
                </p>
                <p>
                This disconnect appears to drive impulse pet rabbit purchases, says Anne Martin, executive director of the House Rabbit Society, the largest rabbit rescue organization in the U.S. Because many people think they’re short-lived, low maintenance, cage-bound animals, rabbits are seen as “starter pets,” akin to hamsters or goldfish, perfect for kids. This misconception may help drive a glut of baby bunny sales ahead of Easter—and a subsequent rise in rabbit abandonments.
                </p>
                <p>
                Jennifer McGee, co-manager of the Georgia chapter of House Rabbit Society, a shelter in the southeastern part of the state, says they normally receive one to two calls a week about abandoned rabbits. But in the six weeks after Easter, the shelter gets three to four calls a day. House Rabbit Society chapters in Idaho and Chicago report a more noticeable rise in summer, as “Easter bunnies” hit puberty and reality sets in for owners.
                </p>
                <p>
                And here’s the reality: Although rabbits can make delightful companions, they’re not easy-care pets. Vets and insurance companies consider them exotic pets, so medical care can be more expensive than for a cat or dog. Rabbits need a lot of exercise and shouldn’t simply be pent up in a cage. This means they need to learn to use a litterbox (yes, rabbits can be potty trained), which takes patience, just as it does for cats. They’re also prey animals, and we’re, well, predators. They generally don’t like to be picked up by humans; they prefer to be in control, their feet on the ground.
                </p>
                <p>
                Rabbits’ complexity means they often face a grim fate when purchased on a whim. Seemingly cute and cuddly, once baby bunnies mature, at between three and six months old, they can become aggressive and even destructive. Proper exercise, litterbox training, and spaying or neutering curbs the problem for most rabbits. But many new owners assume that the undesirable behaviors are the sign of a problem rabbit and get rid of it. Others may do a little research and balk at the time and money it takes to change bunny behavior. McGee says she’s often met with shock and frustration from parents: “What do you mean I have to spend $200 to fix a $30 rabbit?”
                </p>`, 
      image: '/assets/images/rabbit.jpg',
      isselected: false,
      allowedit: false,
      species: 
      [
          {
                id: 1,
                name: 'Holland Lop',
                averageheight: 10,
                averageweight: 32,
                averagelength: 50
          },
          {
                id: 2,
                name: 'Deilenaar',
                averageheight: 9,
                averageweight: 40,
                averagelength: 34
          },
          {
                id: 3,
                name: 'Mini Lop',
                averageheight: 8,
                averageweight: 39,
                averagelength: 52
          },
          {
                id: 4,
                name: 'Pygmy rabbit',
                averageheight: 5,
                averageweight: 34,
                averagelength: 23
          },
          {
                id: 5,
                name: 'Rex rabbit',
                averageheight: 4,
                averageweight: 43,
                averagelength: 34
          }
      ]
  },
  { 
      id: 2, 
      name: 'Turtle', 
      summary: `Turtles are reptiles of the order Testudines (or Chelonii[3]) characterised by a special bony or cartilaginous shell developed from their ribs and acting as a shield.[4] "Turtle" may refer to the order as a whole (American English) or to fresh-water and sea-dwelling testudines                 (British English).[5]
                The order Testudines includes both extant (living) and extinct species. The earliest known members of this group date from 157 million years ago,[1] making turtles one of the oldest reptile groups and a more ancient group than snakes or crocodilians. Of the 327 known species alive today, some are highly endangered.[6][7]
                Turtles are ectotherms—animals commonly called cold-blooded—meaning that their internal temperature varies according to the ambient environment. However, because of their high metabolic rate, leatherback sea turtles have a body temperature that is noticeably higher than that of the surrounding water.
                Turtles are classified as amniotes, along with other reptiles, birds, and mammals. Like other amniotes, turtles breathe air and do not lay eggs underwater, although many species live in or around water.`, 
      image: 'https://rincon.surfrider.org/wp-content/uploads/2016/02/Sea_Turtle_506f386b36187-1.jpg',
      isselected: false,
      allowedit: false,
      species: 
      [
          {
                id: 6,
                name: 'Tortoise',
                averageheight: 10,
                averageweight: 32,
                averagelength: 50
          },
          {
                id: 7,
                name: 'Sea Turtle',
                averageheight: 9,
                averageweight: 40,
                averagelength: 34
          },
          {
                id: 8,
                name: 'Box Turtle',
                averageheight: 8,
                averageweight: 39,
                averagelength: 52
          },
          {
                id: 9,
                name: 'Trionychidae',
                averageheight: 5,
                averageweight: 34,
                averagelength: 23
          },
          {
                id: 10,
                name: 'Emydidae',
                averageheight: 4,
                averageweight: 43,
                averagelength: 34
          }
      ]
  }
];