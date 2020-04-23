class LinkedListInterface
    def count
        raise "Property \"count\" is not implemented."
    end

    def next_element
        raise "Property \"next_element\" is not implemented."
    end

    def first_value
        raise "Property \"first_value\" is not implemented."
    end

    def last_value
        raise "Property \"last_value\" is not implemented."
    end
    


    def add_value(value)
        raise "Method \"add_value\" is not implemented."
    end

    # Raises an IndexError when the index is out of bounds
    def get_value(index)
        raise "Method \"get_value\" is not implemented."
    end

    # Raises an IndexError when the index is out of bounds
    def remove_value(index)
        raise "Method \"remove_value\" is not implemented."
    end

   
end