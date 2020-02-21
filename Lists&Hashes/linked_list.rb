class List (element)
  
  @element = element 
  List.nextValue

  def add(nextVal)
    if List.nextValue == nil
      next = List.new
    else 
      next.add(nextVal)
    end
  end
end