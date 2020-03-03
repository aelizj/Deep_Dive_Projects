class ListItem
  attr_accessor :value

  def initialize(value)
    @value = value
  end

  def add_Item(value)
   #@next_value = nil

    if @next_value == nil
      @next_value = ListItem.new(value)

      p "IF BLOCK"
      p @next_value
    
    else 
      p "ELSE BLOCK"
      p @next_value
       @next_value.add_Item(value) 

            
    end
  end


end

class List 
  def initialize
    p "** INITIALIZING... **"    
    @count = 0
    @is_empty =  true
    @item = nil
    @first_value = nil
    @last_value = nil
  end

  def add_ListItem(value)
    p ">>> BEGINNING OF ADD LIST ITEM METHOD <<<" 

    if @is_empty == true
      @item = ListItem.new(value)
      @count += 1
      @is_empty = false      
      p ">> if block executed<< "
      @first_value = @item.value      
      return
    else 
      @item.add_Item(value)
      @count += 1
      p ">> else block executed <<"
      return
    end
  end

  def first_value
    return @first_value
  end
  
  def last_value
  end
  
  def get_value(index)
  end
  
  def remove_value(index)
  end
  
  def next_element
  end
end

########################################
# p a = List.new
# puts ""

# p "#-------- ADDING FIRST THING -----------#"
# p a.add_ListItem("thing 1")
# p a
# puts ""

# p "#--------- ADDING SECOND THING ----------#"
# p a.add_ListItem("thing 2")
# p a 
# puts ""

# p "#---------ADDING THIRD THING ----------#"
# p a.add_ListItem("thing 3")
# p a 
# puts ""

# p "#---------ADDING FOURTH THING ----------#"
# p a.add_ListItem("thing 4")
# p a 
# puts ""

# p "FIRST + LAST VALUE, RESPECTIVELY:"
# p a.first_value
# p a.last_value
