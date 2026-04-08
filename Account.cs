namespace knightmoves;

public class Account {
 public string Name { get; private set; }
 private string ChangeName(string newName) {
  Name = newName;
  return Name;
 }
}